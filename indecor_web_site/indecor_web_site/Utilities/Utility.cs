﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.Utilities
{
    public class Utility
    {
        public static bool DeleteImgFromFolder(string root, string image)
        {
            string path = Path.Combine(root, "img", image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }

        public enum Roles
        {
            Admin,
            Member
        }

        public const string AdminRole = "Admin";
        public const string MemberRole = "Member";
    }
}
