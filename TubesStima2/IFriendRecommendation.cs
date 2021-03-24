using System;
using System.Collections.Generic;

namespace TubesStima2
{
    interface IFriendRecommendation
    {
        /* Returns dictionary with key is friend which is recommended and value is set of
         * mutual friend (string) for key and user (string). Friend is recommended for user
         * if there exists at least one mutual friend. */
        IList<Tuple<string, HashSet<string>>> getFriendRecommendation(GrafAdj network, string user);
    }
}
