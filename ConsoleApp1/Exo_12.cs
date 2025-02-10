using System.Text;

namespace ConsoleApp1
{
    //tree horizontal browsing

    /*
    LA
        CAR
            NET
            TE
            TABLE
        PE
            AU
     */

    public class TreeNode<T>
    {
        public T Root { get; set; }

        public List<TreeNode<T>> Nodes { get; } = new List<TreeNode<T>>();

        public string Result { get; set; }

        public void BreathFirstSearch(Action<T> action = null)
        {
            Result = Root.ToString();
            Search(new List<TreeNode<T>>() { this });
        }

        public void Search(List<TreeNode<T>> level) 
        {
            var nextLevel = level.SelectMany(x => x.Nodes).ToList();
            if (nextLevel.Count == 0) return;
            Result += "-" + string.Join("-", nextLevel);
            Search(nextLevel);
        }

        public TreeNode(T root)
        {
            Root = root;
        }

        public override string ToString() { return $"{Root.ToString()}"; }
    }

    public class Exo_12
    {
        public static void Main()
        {
            // Creating the tree structure based on the provided diagram
            TreeNode<string> root = new TreeNode<string>("LA");

            TreeNode<string> nodeCar = new TreeNode<string>("CAR");
            TreeNode<string> nodePe = new TreeNode<string>("PE");

            TreeNode<string> nodeNet = new TreeNode<string>("NET");
            TreeNode<string> nodeTe = new TreeNode<string>("TE");
            TreeNode<string> nodeTable = new TreeNode<string>("TABLE");
            TreeNode<string> nodeAu = new TreeNode<string>("AU");

            // Building the tree
            root.Nodes.Add(nodeCar);
            root.Nodes.Add(nodePe);

            nodeCar.Nodes.Add(nodeNet);
            nodeCar.Nodes.Add(nodeTe);
            nodeCar.Nodes.Add(nodeTable);

            nodePe.Nodes.Add(nodeAu);

            root.BreathFirstSearch();
            Console.WriteLine(root.Result);
        }
    }
}