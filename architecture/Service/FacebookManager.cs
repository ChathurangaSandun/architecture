using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace architecture.Service
{
    public class FacebookManager : IFaceBookManager
    {
        private readonly string _username;
        private readonly string _token;

        public FacebookManager(string username, string token)
        {
            _username = username;
            _token = token;
        }

        public bool AuthenticateUser()
        {
            if (!string.IsNullOrEmpty(_username) && !string.IsNullOrEmpty(_token))
            {
                return true;
            }
            return false;
        }
    }
}