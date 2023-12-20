﻿namespace OnlyFriends {
	internal interface UserActions {

		void addPost(string title, string content);
		void deletePost(int postId);
		void addFriend(int friendId);
		void acceptFriendRequest(int friendId);

	}
}
