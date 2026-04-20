using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{ 
    class Program
    {
    public void ucs(Dictionary<int, List<int>> adjList, int root, int goal)
    {

    }
    SortedList<int, int> pq = new SortedList<int, int>();

        static void Main(string[] args)
        {
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int Num_node = Convert.ToInt32(Console.ReadLine());
            int Num_vertex = Convert.ToInt32(Console.ReadLine());

            int src, des;
            for (int i=0; i< Num_vertex; i++)
            {
                Console.Write("src:");
                src = Convert.ToInt32(Console.ReadLine());
                Console.Write("des");
                des = Convert.ToInt32(Console.ReadLine());

                if(!adjList.ContainsKey(src))
                {
                    adjList[src] = new List<int>();
                }
                if (!adjList.ContainsKey(des))
                {
                    adjList[des] = new List<int>();
                }

                adjList[src].Add(des);
                adjList[des].Add(src);
            }

           
     }
    }
    }
}
