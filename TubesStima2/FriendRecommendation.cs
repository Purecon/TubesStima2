using System.Collections.Generic;

namespace TubesStima2
{
    class FriendRecommendation : IFriendRecommendation
    {
        /* Constructor */
        private boolean currentResultExists;
        private List<(string, HashSet<string>)> currentResult;
        private GraphAdj currentNetwork;
        private string currentUser;

        public FriendRecommendation()
        {
            currentResultExists = false;
        }

        /* From IFriendRecommendation */
        public IList<(string, ICollection<string>)> getFriendRecommendation(GraphAdj network, string user)
        {
            if (isNeedToFindResult())
            {
                update(network, user);
            }

            return new List<(string, HashSet<string>)>(currentResult);
        }

        /* Returns true if the network and user are different from previous update.
         * If not currentResultExists, returns true. */
        private boolean isNeedToFindResult(GraphAdj network, string user)
        {
            if (currentResultExists)
            {
                return !(network == currentNetwork && user == currentUser);
            }
            return true;
        }

        /* Update solution */
        private void update(GraphAdj network, string user)
        {
            currentResult = new List<(string, HashSet<string>)>();
            KeyValuePair<string, string> userToUserFriendsKvp = network.getMap().Find(edgeKvp => edgeKvp.key == user);
            if (!KeyValuePair<string, string>.IsNullOrEmpty(userToUserFriendsKvp))
            {
                HashSet userFriends = new HashSet<string>(userToUserFriendsKvp.Value.Split(' '));

                foreach (string friend in userFriends)
                {
                    foreach (string friendOfFriend in network.getMap().Find(edgeKvp => edgeKvp.key == friend).Value.Split(' '))
                    {
                        if (friendOfFriend != user)
                        {
                            KeyValuePair<string, string> prevSameFriendOfFriendKvp = currentResult.Find(prevFriend => prevFriend.Item1 == friendOfFriend);
                            if (KeyValuePair<string, string>.IsNullOrEmpty(prevSameFriendOfFriendKvp))
                            {
                                List<string> friendInitialList = new List<string>();
                                friendInitialList.Add(friend);
                                currentResult.Add((friendOfFriend, new List<string>(friendInitialList)));
                            }
                            else
                            {
                                prevSameFriendOfFriendKvp.Item2.Add(friend);
                            }
                        }
                    }
                }

                currentResult.Sort((x, y) => x.Item2.Count().CompareTo(y.Item2.Count()));
            }

            currentNetwork = network;
            currentUser = user;
            currentResultExists = true;
        }
    }
}
