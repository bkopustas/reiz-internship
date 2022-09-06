using System;

namespace TreeDepth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Branch(new List<Branch>()
            {
                new Branch(new List<Branch>()
                {
                    new Branch()
                }),
                new Branch(new List<Branch>()
                {
                    new Branch(new List<Branch>()
                    {
                        new Branch()
                    }),
                    new Branch(new List<Branch>()
                    {
                        new Branch(new List<Branch>()
                        {
                            new Branch()
                        }),
                        new Branch()
                    }),
                    new Branch()
                })
            });

            Console.WriteLine($"Tree depth: {GetTreeDepth(tree)}");
        }

        static int GetTreeDepth(Branch root)
        {
            if (root.branches.Count == 0) 
                return 1;

            int depth = 0;
            foreach (var branch in root.branches)
            {
                depth = Math.Max(depth, GetTreeDepth(branch));
            }
            return depth + 1;
        }
    }
}