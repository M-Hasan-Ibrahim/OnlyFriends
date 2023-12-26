﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends.Components {
    public partial class FriendRequestComponent : UserControl {
        public FriendRequestComponent() {
            InitializeComponent();
        }

        #region Properties

        private int userId;
        private int friendId;
        private string userName;
        private string email;
        public int FriendId { get; set; }
        public int UserId { get; set; }
        public string UserName {
            get { return userName; }
            set { userName = value; usernameLabel.Text = userName; }
        }
        public string Email {
            get { return Email; }
            set { email = value; emailLabel.Text = value; }
        }

        #endregion Properties

        private void acceptButton_Click(object sender, EventArgs e) {
            try {
                User user = User.Instance;
                user.acceptFriendRequest(FriendId);
                MessageBox.Show($"{UserName} is now added to your friends list", "New Friend");
                this.Visible = false;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void rejectButton_Click(object sender, EventArgs e) {
            this.Visible = false;
            MessageBox.Show($"{UserName} is removed from your friend requests");
        }
    }
}
