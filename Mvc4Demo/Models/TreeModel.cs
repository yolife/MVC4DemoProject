using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Demo.Models
{
    public class TreeNode
    {
        public string Name { get; set; }
        public List<TreeNode> Children { get; set; }
    }

    public class TreeModel
    {
        public static List<TreeNode> GetHardCodedData()
        {
            List<TreeNode> Nodes = new List<TreeNode>();

            TreeNode root = new TreeNode() { Name = "Root", Children = new List<TreeNode>() };
            TreeNode folder1 = new TreeNode() { Name = "Folder 1", Children = new List<TreeNode>() };
            TreeNode folder2 = new TreeNode() { Name = "Folder 2", Children = new List<TreeNode>() };
            root.Children.AddRange(new List<TreeNode>() { folder1, folder2 });

            TreeNode folder11 = new TreeNode() { Name = "Folder 1.1", Children = new List<TreeNode>() };
            TreeNode folder12 = new TreeNode() { Name = "Folder 1.2", Children = new List<TreeNode>() };
            folder1.Children.AddRange(new List<TreeNode>() { folder11, folder12 });

            TreeNode folder21 = new TreeNode() { Name = "Folder 2.1", Children = new List<TreeNode>() };
            TreeNode folder22 = new TreeNode() { Name = "Folder 2.2", Children = new List<TreeNode>() };
            folder2.Children.AddRange(new List<TreeNode>() { folder21, folder22 });

            TreeNode folder221 = new TreeNode() { Name = "Folder 2.2.1", Children = new List<TreeNode>() };
            TreeNode folder222 = new TreeNode() { Name = "Folder 2.2.2", Children = new List<TreeNode>() };
            TreeNode folder223 = new TreeNode() { Name = "Folder 2.2.3", Children = new List<TreeNode>() };
            folder22.Children.AddRange(new List<TreeNode>() { folder221, folder222, folder223 });

            Nodes.AddRange(new List<TreeNode>() { root });
            return Nodes;
        }
    }
}