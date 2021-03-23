namespace TubesStima2
{
    interface IExploreFriend
    {
        /*  Returns array of string for connection from src to dest in
         *  network.
         */
        string[] getConnection(GraphAdj network, string src, string dest);

        /*  Returns degree of connection for src to dest. It is defined by
         *  how many friend are passed in connection of src to dest.
         *  E.g.: If src = A, dest = B, and the connection is A->D->C->B,
         *        then degree of connection is 2.
         */
        int getDegreeConnection(GraphAdj network, string src, string dest);
    }
}
