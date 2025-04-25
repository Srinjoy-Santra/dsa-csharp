#!/bin/bash

# Ensure the script receives at least one argument
if [ "$#" -lt 1 ]; then
    echo "Usage: $0 <source_filepath> [source_dir]"
    exit 1
fi

# Arguments
SOURCE_FILEPATH=$1
SOURCE_DIR=${2:-.} # Default to current directory if not provided
#OUTPUT_DIR=${3:-$SOURCE_DIR} # Default to source directory if output directory is not provided
OUTPUT_DIR=${3:-/mnt/z/vaults/zettelkasten/Informatik/DSA/notebooks} # Default to a custom path if not provided

# Extract the filename from the given filepath
FILENAME=$(basename "$SOURCE_FILEPATH")

# Check if the file exists in the specified directory
if [ -f "$SOURCE_DIR/$FILENAME.md" ]; then
    echo "File '$FILENAME.md' exists in '$SOURCE_DIR'. Syncing..."
        
    # Assign files
    FILE1=$OUTPUT_DIR/$FILENAME.md # external md
    FILE2=$SOURCE_DIR/$FILENAME.md # internal md
    FILE3=$SOURCE_DIR/$FILENAME.cs # internal cs
    
    # Check if all files exist
    if [ ! -f "$FILE1" ] || [ ! -f "$FILE2" ] || [ ! -f "$FILE3" ]; then
        echo "Error: All three files must exist."
        exit 1
    fi
    
    # Find the latest file
    LATEST_FILE=$FILE1
    if [ "$FILE2" -nt "$LATEST_FILE" ]; then
        LATEST_FILE=$FILE2
    fi
    if [ "$FILE3" -nt "$LATEST_FILE" ]; then
        LATEST_FILE=$FILE3
    fi
    
    # Output the latest file
    echo "The most recently modified file is: $LATEST_FILE"
    
    # If code is latest, sync with local markdown 
    if [ "$LATEST_FILE" = "$FILE3" ]; then
        jupytext --sync "$FILE3"
    fi
    
    # Compare modification times
    if [ "$FILE1" -nt "$FILE2" ]; then
        echo "File '$FILE1' is newer. Copying its content to '$FILE2'."
        cp "$FILE1" "$FILE2"
    elif [ "$FILE2" -nt "$FILE1" ]; then
        echo "File '$FILE2' is newer. Copying its content to '$FILE1'."
        cp "$FILE2" "$FILE1"
    else
        echo "Both files have the same modification time. No action taken."
    fi
    
    echo "Operation complete."
    jupytext --sync "$SOURCE_DIR/$FILENAME.cs"
    # If code is not latest, sync from local markdown 
    if [ "$LATEST_FILE" != "$FILE3" ]; then
        jupytext --sync "$FILE2"
    fi
    echo "File synced successfully!"
else
    echo "File '$FILENAME.md' does not exist in '$SOURCE_DIR'. Creating..."
    jupytext --set-formats md,cs "$SOURCE_DIR/$FILENAME.cs"
    echo "File created successfully!"
fi

echo "$SOURCE_DIR/$FILENAME.md" "$OUTPUT_DIR/."
cp "$SOURCE_DIR/$FILENAME.md" "$OUTPUT_DIR/."
