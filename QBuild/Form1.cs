using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QBuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
           

        }
        QuBuildContext _context = new QuBuildContext();

        private void btn_populate_Click(object sender, EventArgs e)
        {
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            btn_populate.Enabled = false;
          

            var nodes = _context.bmoes.Where(c => c.PARENT_NAME .Equals(""));



            foreach (var  node in nodes)
            {

                TreeNode rootNode = new TreeNode(node.COMPONENT_NAME);
             
                var childNode = 
                    (from a in _context.bmoes
                    join b in _context.bmoes 
                        on a.COMPONENT_NAME equals b.PARENT_NAME
                    select new { a.PARENT_NAME}).Distinct( );

                foreach (var child  in childNode)
                {
                    if (child .PARENT_NAME != node.PARENT_NAME)
                    {
                        TreeNode chiTreeNode = new TreeNode(child .PARENT_NAME);
                    
                        var grandChilds = _context.bmoes.Where( a => a.PARENT_NAME  == child.PARENT_NAME);
                        foreach (var grandChild in grandChilds )
                        {
                            TreeNode grandChildTreeNode = new TreeNode(grandChild .COMPONENT_NAME);
                         
                            chiTreeNode.Nodes.Add(grandChildTreeNode);

                        }
                      
                        rootNode.Nodes.Add(chiTreeNode);
                    }
                  
                }

                treeview_populateData.Nodes.Add(rootNode);


            }
            

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string .IsNullOrEmpty( treeview_populateData .SelectedNode.Text) )
            {
                lbl_CurentPart.Text = "Current Part : " + treeview_populateData.SelectedNode.Text;

                var node = treeview_populateData.SelectedNode.Parent;
                if (node!= null )
                {
                    lbl_ParentChildPart.Text = "Parent Child Part : " + node.Text + " / " + treeview_populateData.SelectedNode.Text;

                    var selectedNode = treeview_populateData.SelectedNode.Text;
                    var queryable = from a in _context.bmoes
                        join b in _context.Parts
                            on a.COMPONENT_NAME equals b.NAME into result
                        from r in result.DefaultIfEmpty()
                        where a.PARENT_NAME == selectedNode
                  
                        select new { PARENT_NAME=a.PARENT_NAME , COMPONENT_NAME = a.COMPONENT_NAME, RT_NUMBER =r.PART_NUMBER, TITLE=r.TITLE, QUANTITY = a.QUANTITY , TYPE =r.TYPE , ITEM=r.ITEM , MATERIA=r.MATERIAL , };
                    dataGrid_showData.DataSource = queryable.ToList();
                }

                
            }


           
     


            








        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
