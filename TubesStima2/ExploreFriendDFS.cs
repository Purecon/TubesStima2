using System;
using System.Collections.Generic;
using System.Linq;

namespace TubesStima2
{
    class ExploreFriendDFS : IExploreFriend
    {
        private bool currentResultExists;
        private bool currentConnectionFound;
        private GrafAdj currentNetwork;
        private string currentSrc;
        private string currentDest;
        private List<string> currentConnection;

        /* Constructor */
        public ExploreFriendDFS()
        {
            currentResultExists = false;

        }

        /* IExploreFriend implementation */
        public string[] getConnection(GrafAdj network, string src, string dest)
        {
            if (isNeedToFindResult(network, src, dest))
            {
                update(network, src, dest);
            }

            if (currentConnectionFound)
            {
                return currentConnection.ToArray();

            }
            else
            {
                throw new NoConnectionException(src, dest);
            }
        }
        public int getDegreeConnection(GrafAdj network, string src, string dest)
        {
            if (isNeedToFindResult(network, src, dest))
            {
                update(network, src, dest);
            }

            if (currentConnectionFound)
            {
                return currentConnection.Count - 2;
            }
            else
            {
                throw new NoConnectionException(src, dest);
            }

        }

        /* Returns true if the network, src, and dest are different from previous update.
         * If not currentResultExists, returns true. */
        private bool isNeedToFindResult(GrafAdj network, string src, string dest)
        {
            if (currentResultExists)
            {
                return !(network == currentNetwork && src == currentSrc && dest == currentDest);
            }
            return true;
        }

        /* Update solution */
        private void update(GrafAdj network, string src, string dest)
        {
            if (src == dest) {
                throw new SelfConnectionException(src);
            }
            List<string> connection = new List<string>();
            string srcAdjacentString;
            currentConnectionFound = dfs(network, src, dest, ref connection);
            currentNetwork = network;
            currentSrc = src;
            currentDest = dest;
            if (currentConnectionFound)
            {
                currentConnection = new List<string>(connection);
            }
            currentResultExists = true;
        }

        /* Returns true if dest found from src in graph with DFS, solution is concatenate with route from src to dest.
         * If not found, returns false and solution does not change. */
        private bool dfs(GrafAdj graph, string src, string dest, ref List<string> solution)
        {
            if (src == dest)
            {
                solution.Add(src);
                return true;
            }
            else if (solution.Contains(src))
            {
                return false;
            }
            else
            {
                string srcAdjacentString;

                if (graph.getMap().TryGetValue(src, out srcAdjacentString))
                {
                    solution.Add(src);
                    bool found = false;
                    foreach (string adjacentNode in srcAdjacentString.Split(' ')) {
                        if (dfs(graph, adjacentNode, dest, ref solution)) {
                            found = true;
                            break;
                        }
                    }

                    if (!found) {
                        solution.Remove(src);
                    }

                    return found;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    class NoConnectionException : Exception
    {
        public NoConnectionException(string src, string dest) :
                base("No connection from \"" + src + "\" to \"" + dest + "\"!")
        { }
    }

    class SelfConnectionException : Exception
    {
        public SelfConnectionException(string src) :
                base("Self connection detected from \"" + src + "\"!")
        { }
    }
}
