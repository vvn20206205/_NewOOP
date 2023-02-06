using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan11Bai2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var drives = Directory.GetLogicalDrives();
            foreach(var drive in drives) {
                var driveNode = new TreeNode(drive);
                driveNode.Nodes.Add("");
                treeView1.Nodes.Add(driveNode);
            }
        }

        private void treeView1_AfterSelect(object sender,TreeViewEventArgs e) {
            var node = e.Node;
            var path = node.FullPath;

            listView1.Items.Clear();

            try {
                var directories = Directory.GetDirectories(path);
                foreach(var directory in directories) {
                    var item = new ListViewItem(new DirectoryInfo(directory).Name);
                    item.ImageIndex=0;
                    listView1.Items.Add(item);
                }

                var files = Directory.GetFiles(path);
                foreach(var file in files) {
                    var item = new ListViewItem(new FileInfo(file).Name);
                    item.ImageIndex=1;
                    listView1.Items.Add(item);
                }
            } catch(UnauthorizedAccessException) {
                listView1.Items.Add("Truy cập bị từ chối");
            }
        }

        private void treeView1_BeforeExpand(object sender,TreeViewCancelEventArgs e) {
            var node = e.Node;
            if(node.Nodes.Count==1&&node.Nodes[0].Text=="") {
                node.Nodes.Clear();
                var path = node.FullPath;

                try {
                    var directories = Directory.GetDirectories(path);
                    foreach(var directory in directories) {
                        var directoryNode = new TreeNode(new DirectoryInfo(directory).Name);
                        directoryNode.Nodes.Add("");
                        node.Nodes.Add(directoryNode);
                    }

                    var files = Directory.GetFiles(path);
                    foreach(var file in files) {
                        var fileNode = new TreeNode(new FileInfo(file).Name);
                        node.Nodes.Add(fileNode);
                    }
                } catch(UnauthorizedAccessException) {
                    node.Nodes.Add("Truy cập bị từ chối");
                }
            }
        }
    }
}
