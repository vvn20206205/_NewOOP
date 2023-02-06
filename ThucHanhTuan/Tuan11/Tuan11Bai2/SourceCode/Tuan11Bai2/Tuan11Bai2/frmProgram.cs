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
    public partial class frmProgram : Form { 
        #region Constructor
        public frmProgram() {
            InitializeComponent();
        }
        #endregion
        #region Methods
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var _Drives = Directory.GetLogicalDrives();
            foreach(var itemDrives in _Drives) {
                var _DriveNode = new TreeNode(itemDrives);
                _DriveNode.Nodes.Add("");
                tvFather.Nodes.Add(_DriveNode);
            }
        }
        #endregion

        #region Events
        private void tvFather_AfterSelect(object sender,TreeViewEventArgs e) {
            var _Node = e.Node;
            var _Path = _Node.FullPath;

            lvChild.Items.Clear();

            try {
                var _Directories = Directory.GetDirectories(_Path);
                foreach(var itemDirectories in _Directories) {
                    var _Item = new ListViewItem(new DirectoryInfo(itemDirectories).Name);
                    _Item.ImageIndex=0;
                    lvChild.Items.Add(_Item);
                }

                var _Files = Directory.GetFiles(_Path);
                foreach(var itemFiles in _Files) {
                    var _item = new ListViewItem(new FileInfo(itemFiles).Name);
                    _item.ImageIndex=1;
                    lvChild.Items.Add(_item);
                }
            } catch(UnauthorizedAccessException) {
                lvChild.Items.Add("Truy cập bị từ chối");
            }
        }

        private void tvFather_BeforeExpand(object sender,TreeViewCancelEventArgs e) {
            var _Node = e.Node;
            if(_Node.Nodes.Count==1&&_Node.Nodes[0].Text=="") {
                _Node.Nodes.Clear();
                var _Path = _Node.FullPath;

                try {
                    var _Directories = Directory.GetDirectories(_Path);
                    foreach(var itemDirectories in _Directories) {
                        var _DirectoryNode = new TreeNode(new DirectoryInfo(itemDirectories).Name);
                        _DirectoryNode.Nodes.Add("");
                        _Node.Nodes.Add(_DirectoryNode);
                    }

                    var _Files = Directory.GetFiles(_Path);
                    foreach(var itemFiles in _Files) {
                        var _FileNode = new TreeNode(new FileInfo(itemFiles).Name);
                        _Node.Nodes.Add(_FileNode);
                    }
                } catch(UnauthorizedAccessException) {
                    _Node.Nodes.Add("Truy cập bị từ chối");
                }
            }
        }
        #endregion
    }

}
