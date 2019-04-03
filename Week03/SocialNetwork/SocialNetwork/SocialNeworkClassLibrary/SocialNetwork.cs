using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNeworkClassLibrary
{
    public class SocialNetwork
    {
        private List<Member> members = new List<Member>();

        public void AddMember(string name)
        {
            Member newMember = new Member(name);
            members.Add(newMember);

        }

        public Member FindByName(string name)
        {
            Member foundIt = null;
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name == name)
                {
                    foundIt = members[i];
                    break;
                }
            }
            return foundIt;
        }

        /*Legyen egy void Connect(string name, string anotherName) metódusa, 
         * mely kikeresi az első tagot név szerint, 
         * majd kikeresi a második tagot név szerint 
         * és meghívja az első ConnectMember metódusát a második taggal, mint paraméterrel.
         */
        public void Connect(string name, string anotherName)
        {
            Member firstTag = FindByName(name);

            Member secondTag = FindByName(anotherName);

            firstTag.ConnectMember(secondTag);
        }

        public string GetBidirectionalConnections()
        {
            string biDiConnections = "";

            for (int i = 0; i < members.Count; i++)
            {
                for (int j = 0; j < members[i].Connections.Count; j++)
                {
                    if (members[i].Connections[j].Connections.Contains(members[i]) == true)
                    {
                        biDiConnections = biDiConnections + members[i].Name + " & " + members[i].Connections[j].Name + ", ";
                    }

                }
            }

            return biDiConnections;

        }
    }
}
