using System.Collections.Generic;

namespace TubesStima2
{
    class ExploreFriendDFS : IExploreFriend
    {
        private boolean currentResultExists;
        private boolean currentConnectionFound;
        private GraphAdj currentNetwork;
        private string currentSrc;
        private string currentDest;
        private List<string> currentConnection;

        /* Constructor */
        public ExploreFriendDFS()
        {
            currentResultExists = false;

        }

        /* IExploreFriend implementation */
        public string[] getConnection(GraphAdj network, string src, string dest)
        {
            if (isNeedToFindResult())
            {
                update();
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
        public int getDegreeConnection(GraphAdj network, string src, string dest)
        {
            if (isNeedToFindResult())
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
        private boolean isNeedToFindResult(GraphAdj network, string src, string dest)
        {
            if (currentResultExists)
            {
                return !(network == currentNetwork && src == currentSrc && dest == currentDest);
            }
            return true;
        }

        /* Update solution */
        private void update(GraphAdj network, string src, string dest)
        {
            List<string> connection = new List<string>();
            connection.Add(src);
            currentConectionFound = graph.getMap().Contains(edgeKvp => dfs(network, src, edgeKvp.value, ref connection));
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
        private boolean dfs(GraphAdj graph, string src, string dest, ref List<string> solution)
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
                KeyValuePair srcEdgeKvp = graph.getMap().Find(edgeKvp => edgeKvp.value == src);
                if (KeyValuePair<string, string>.IsNullOrEmpty(srcEdgeKvp))
                {
                    return false;
                }
                else
                {
                    boolean found = srcEdgeKvp.Value.Split(' ').Contains(adjacentNode => dfs(graph, src, adjacentNode, out tailSolution));
                    if (found)
                    {
                        solution.Concat(tailSolution);
                    }
                    return found;
                }
            }
        }
    }
}
