﻿// YAHW - Yet Another Hardware Monitor
// Copyright (c) 2015 Steffen Steinbrecher
// Contact and Information: http://csharp-blog.de/category/yahw/
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
// THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHW.Constants
{
    public static class DirectoryConstants
    {
        /// <summary>
        /// The application data folder
        /// </summary>
        public static string ApplicationDataFolder
        {
            get
            {
                string basePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "YAHW");

                // Create directory if not exists
                if (!System.IO.Directory.Exists(basePath))
                    System.IO.Directory.CreateDirectory(basePath);

                return basePath;
            }
        }

        /// <summary>
        /// Application config
        /// </summary>
        public static string ApplicationConfig
        {
            get
            {
                return System.IO.Path.Combine(ApplicationDataFolder, "ApplicationSettings.xml");
            }
        }

        /// <summary>
        /// Folder with the log files
        /// </summary>
        public static string LogFileFolder
        {
            get
            {
                return System.IO.Path.Combine(ApplicationDataFolder, "Logs");
            }
        }

        /// <summary>
        /// The file with the fan controller templates
        /// </summary>
        public static string FanControllerTemplatesConfig
        {
            get
            {
                return System.IO.Path.Combine(System.Environment.CurrentDirectory, @"ConfigFiles\FanControllerTemplates.xml");
            }
        }

        /// <summary>
        /// The file with the fan controller settings
        /// </summary>
        public static string FanControllerSettingsConfig
        {
            get
            {
                return System.IO.Path.Combine(ApplicationDataFolder, "FanControllerSettings.xml");
            }
        }

        /// <summary>
        /// The file with the tile view settings
        /// </summary>
        public static string TileViewSettingsConfig
        {
            get
            {
                return System.IO.Path.Combine(ApplicationDataFolder, "TileViewSettings.xml");
            }
        }

        /// <summary>
        /// The License-File
        /// </summary>
        public static string LicenseFile
        {
            get
            {
                return System.IO.Path.Combine(System.Environment.CurrentDirectory, "LICENSE.txt");
            }
        }
    }
}