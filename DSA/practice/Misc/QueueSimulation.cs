namespace DSA.practice.Misc;

public class QueueSimulation
{
    public bool Solution(int[] common, int[] vip, int buy) {
        
        List<int> vipList = new List<int>(vip);
        vipList.Add(buy);
        double vipCost = FindTime(vipList, vip.Length);
        
        List<int> commonList = new List<int>(common);
        commonList.Add(buy);
        double commonCost = FindTime(commonList, common.Length);
        
        Console.WriteLine("Cost: " + commonCost + ", " + vipCost);
        return commonCost > vipCost*10;
    }

    private int FindTime(List<int> tickets, int k) {
        int countTime = 0;
        for(int i=0;i<tickets.Count;i++)
        {
            if(i<=k){
                countTime += Math.Min(tickets[k], tickets[i]);    
            } else {
                countTime += Math.Min(tickets[k]-1, tickets[i]);    
            }
        }
        
        return countTime;
    }

    public static void Run()
    {
        int[] vipTickets = [2,1], commonTickets = [3,2]; 
        int myTickets = 4;
        
        QueueSimulation simulation = new QueueSimulation();
        Console.WriteLine(simulation.Solution(commonTickets, vipTickets, myTickets));

    }
    
}