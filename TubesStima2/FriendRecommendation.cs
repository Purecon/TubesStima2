using System;
using System.Collections.Generic;
using System.Linq;

namespace TubesStima2
{
    class FriendRecommendation : IFriendRecommendation
    {
        /* Constructor */
        private bool currentResultExists;
        private List<Tuple<string, HashSet<string>>> currentResult;
        private GrafAdj currentNetwork;
        private string currentUser;

        public FriendRecommendation()
        {
            currentResultExists = false;
        }

        /* From IFriendRecommendation */
        public IList<Tuple<string, HashSet<string>>> getFriendRecommendation(GrafAdj network, string user)
        {
            if (isNeedToFindResult(network, user))
            {
                update(network, user);
            }

            return new List<Tuple<string, HashSet<string>>>(currentResult);
        }

        /* Returns true if the network and user are different from previous update.
         * If not currentResultExists, returns true. */
        private bool isNeedToFindResult(GrafAdj network, string user)
        {
            if (currentResultExists)
            {
                return !(network == currentNetwork && user == currentUser);
            }
            return true;
        }

        /* Update solution */
        private void update(GrafAdj network, string user)
        {
            currentResult = new List<Tuple<string, HashSet<string>>>();
            string userFriendsString;
            if (network.getMap().TryGetValue(user, out userFriendsString))
            {
                HashSet<string> userFriends = new HashSet<string>(userFriendsString.Split(' '));

                foreach (string friend in userFriends)
                {
                    foreach (string friendOfFriend in network.getMap().FirstOrDefault<KeyValuePair<string, string>>(edgeKvp => edgeKvp.Key == friend).Value.Split(' '))
                    {
                        if (friendOfFriend != user)
                        {
                            Tuple<string, HashSet<string>> prevSameFriendOfFriendKvp = currentResult.FirstOrDefault<Tuple<string, HashSet<string>>>(prevFriend => prevFriend.Item1 == friendOfFriend);
                            if (string.IsNullOrEmpty(prevSameFriendOfFriendKvp.Item1))
                            {
                                HashSet<string> friendInitialList = new HashSet<string>();
                                friendInitialList.Add(friend);
                                currentResult.Add(new Tuple<string, HashSet<string>>(friendOfFriend, new HashSet<string>(friendInitialList)));
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
