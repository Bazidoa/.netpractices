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


    }
}
