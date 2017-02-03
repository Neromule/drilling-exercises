using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drilling
{
    public static class Icons
    {
        private static Icon logo_drilling = Properties.Resources.logo_drilling;
        private static Icon user_add_icon = Properties.Resources.user_add_icon;

        private static Image cancel = Properties.Resources.cancel; 
        private static Image sign_up = Properties.Resources.sign_up;
        private static Image add = Properties.Resources.add;
        private static Image user_add = Properties.Resources.user_add;


        public static Icon LogoDrilling { get { return logo_drilling; } }
        public static Icon UserAddIcon { get { return user_add_icon; } }

        public static Image Cancel { get { return cancel; }}
        public static Image UserAdd { get { return user_add; } }
        public static Image SignUp { get { return sign_up; }}
        public static Image Add { get { return add; } }
        



    }
}
