using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNeworkClassLibrary
{
    public class Member
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Member(string name)
        {
            this.name = name;
        }

        private List<Member> connections = new List<Member>();
        public List<Member> Connections
        {
            get
            {
                return connections;
            }
        }

        public void ConnectMember(Member member)
        {
            connections.Add(member);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);

            List<string> bejeloltTagokNevenekListaja=this.GetConnectedNames();

            for (int i = 0; i < bejeloltTagokNevenekListaja.Count; i++)
            {
                sb.Append(bejeloltTagokNevenekListaja[i]);
            }

            return sb.ToString();

        }

        public List<string> GetConnectedNames()
        {
            List<string> bejeloltTagok = new List<string>();

            if (connections.Count == 0)
            {
                bejeloltTagok.Add(": ");
                bejeloltTagok.Add("-");
                bejeloltTagok.Add($"\n");
            }
            for (int i = 0; i < connections.Count; i++)
            {
                bejeloltTagok.Add(": ");
                bejeloltTagok.Add(connections[i].Name);
                bejeloltTagok.Add($"\n");


            }

            return bejeloltTagok;
        }

    }
}
