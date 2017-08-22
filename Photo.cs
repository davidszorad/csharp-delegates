using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesApp
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path");

            return new Photo();
        }

        public void Save()
        {

        }
    }
}
