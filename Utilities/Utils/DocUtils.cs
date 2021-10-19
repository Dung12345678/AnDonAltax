using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Data;

namespace BMS
{
    public class DocUtils
    {
        #region 0. Constructor

        public static Boolean IsHidePanel = false;

        public static string DefaultVersion = "V1.1";
        public static int DefaultToMonthNo = 12;
        public static int DefaultMonthSearch = -12;
        //private static string ftpServerPath = @"ftp://192.168.1.100", ftpUserID = "cpk", ftpPassword = "1234";
        private static string ftpServerPath = "", ftpUserID = "", ftpPassword = "";
        private static int _DepartmentID;
        public static string FtpServerPath
        {
            get { return ftpServerPath; }
            set { ftpServerPath = value; }
        }
        public static string FtpUserID
        {
            get { return ftpUserID; }
            set { ftpUserID = value; }
        }
        public static string FtpPassword
        {
            get { return ftpPassword; }
            set { ftpPassword = value; }
        }

        public static int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        BackgroundWorker bgw = new BackgroundWorker();
        

        #endregion

        #region 1. Define Functions

        private static string GetErrMsg(WebException we)
        {
            if (we.Status == WebExceptionStatus.ProtocolError)
            {
                return ((FtpWebResponse)we.Response).StatusDescription.ToString();
            }
            else
                return we.Message;
        }

        private static string GetSubFormular(string _strFormula, string _Symbol)
        {
            try
            {
               return _strFormula.Substring(_strFormula.IndexOf(_Symbol) + 1, _strFormula.LastIndexOf(_Symbol) - _strFormula.IndexOf(_Symbol) - 1);
            }
            catch
            {
                return "";
            }
        }

        public static string RemoveEndComma(string str)
        {
            if (String.IsNullOrEmpty(str))
                return "";
            str = str.Trim();
            if (str.Substring(str.Length - 1).Equals(","))
                str = str.Substring(0, str.Length - 1);
            return str;
        }

        public static string FormatBytes(decimal bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);
            foreach (string order in orders)
            {
                if (bytes > max)
                {
                    return string.Format("{0:##.##} {1}", Decimal.Divide(bytes, max), order);
                }

                max /= scale;
            }
            return "0 Bytes";
        }

        public static int GetIcon(string strFileExtension)
        {
            int icon = 10;
            strFileExtension = strFileExtension.Replace(".","").ToLower();
            switch (strFileExtension)
            {
                //0.word icon
                case "doc": case "docx":
                    icon = 0; break;

                //1.excel
                case "xls": case "xlsx":
                    icon = 1; break;

                //2.powerpoint
                case "ppt": case "pptx": case "pps":
                    icon = 2; break;

                //3.pdf
                case "pdf":
                    icon = 3; break;

                //4.rar
                case "rar": case "zip": case "7z":
                    icon = 4; break;

                //5.image
                case "jpg": case "jpeg": case "png": case "bmp": case "gif":
                    icon = 5; break;

                //6.sound
                case "mp3": case "wav": case "wma": case"acc": case"mp2": case "m4a":
                    icon = 6; break;

                //7.movie, clip
                case "mpeg": case "mpg": case"avi": case"mp4": case "3gp": case"mov":
                    icon = 7; break;

                //8.exe
                case "exe": case "bin": case "reg": case "dll":
                    icon = 8; break;

                //9.text
                case "txt": case "ini": case "xml": case "html":
                    icon = 9; break;

                //9.text
                case "msg": case "email": case "oft":
                    icon = 11; break;

                //10.file
                default:
                    icon = 10; break;
            }
            return icon;
        }

        #endregion

        #region 2.FTP Functions

        public static void InitFTPQLSX()
        {
            ftpServerPath = "ftp://192.168.20.252";
            ftpUserID = "ftpuser1";
            ftpPassword = "123456!";            
        }

        public static void InitFTPTK()
        {
            ftpServerPath = "ftp://192.168.20.252";
            ftpUserID = "ftpuser5";
            ftpPassword = "123456!";
        }

        /// <summary>
        /// Upload file lên ftp
        /// </summary>
        /// <param name="filePath">Đường dẫn file trên local</param>
        /// <param name="ftpFolderPath">Đường dẫn thư mục trên ftp</param>
        public static void UploadFile(string filePath, string ftpFolderPath)
        {
            FileInfo fileInf = new FileInfo(filePath);
            //string uri = "ftp://" + ftpServerPath + "/" + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + ftpFolderPath + "/" + fileInf.Name));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool UploadFileWithStatus(string filePath, string folderPath)
        {
            try
            {
                FileInfo fileInf = new FileInfo(filePath);
                //string uri = "ftp://" + ftpServerPath + "/" + fileInf.Name;
                FtpWebRequest reqFTP;

                // Create FtpWebRequest object from the Uri provided
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + folderPath + "/" + fileInf.Name));

                // Provide the WebPermission Credintials
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                // By default KeepAlive is true, where the control connection is not closed
                // after a command is executed.
                reqFTP.KeepAlive = false;

                // Specify the command to be executed.
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

                // Specify the data transfer type.
                reqFTP.UseBinary = true;

                // Notify the server about the size of the uploaded file
                reqFTP.ContentLength = fileInf.Length;

                // The buffer size is set to 2kb
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;

                // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
                FileStream fs = fileInf.OpenRead();

                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
                return true;
            }           
            catch
            {
                return false;
            }
        }

        public static void UploadFile(string filename)
        {
            FileInfo fileInf = new FileInfo(filename);
            //string uri = "ftp://" + ftpServerPath + "/" + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + fileInf.Name));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UploadFile(string sourceName,string saveName, ProgressBar progBar, Label lblProgress)
        {
            FileInfo fileInf = new FileInfo(sourceName);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + saveName));
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = fileInf.Length;
            int dataLength = (int)reqFTP.ContentLength;
            int value = 0;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = fileInf.OpenRead();

            //Set up progress bar
            if (progBar != null)
            {
                progBar.Value = 0;
                progBar.Maximum = dataLength;
            }
            if (lblProgress != null)
            {
                lblProgress.Text = "0/" + dataLength.ToString();
            }

            try
            {
                Stream strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);

                    //Update the progress bar
                    if (value + contentLen <= dataLength)
                    {
                        value += contentLen;
                        if (progBar != null)
                        {
                            progBar.Value = value;
                            progBar.Refresh();
                        }
                        if (lblProgress != null)
                            lblProgress.Text = FormatBytes(value) + "/" + FormatBytes(dataLength);

                        Application.DoEvents();
                    }
                }
                strm.Close();
                fs.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UploadFile(string sourceName, string saveName, string folderPath, ProgressBar progBar, Label lblProgress)
        {
            FileInfo fileInf = new FileInfo(sourceName);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + folderPath + "/" + saveName));
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = fileInf.Length;
            int dataLength = (int)reqFTP.ContentLength;
            int value = 0;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = fileInf.OpenRead();

            //Set up progress bar
            if (progBar != null)
            {
                progBar.Value = 0;
                progBar.Maximum = dataLength;
            }
            if (lblProgress != null)
            {
                lblProgress.Text = "0/" + dataLength.ToString();
            }

            try
            {
                Stream strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);

                    //Update the progress bar
                    if (value + contentLen <= dataLength)
                    {
                        value += contentLen;
                        if (progBar != null)
                        {
                            progBar.Value = value;
                            progBar.Refresh();
                        }
                        if (lblProgress != null)
                            lblProgress.Text = FormatBytes(value) + "/" + FormatBytes(dataLength);

                        Application.DoEvents();
                    }
                }
                strm.Close();
                fs.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Download từ ftp về máy
        /// </summary>
        /// <param name="localPath">Folder chứa file</param>
        /// <param name="fileName">Tên file</param>
        /// <param name="ftpFilePath">Đường dẫn file trên ftp</param>
        public static void DownloadFile(string localPath, string fileName, string ftpFilePath)
        {
            FtpWebRequest reqFTP;
            try
            {
                //filePath = <<The full path where the file is to be created.>>, 
                //fileName = <<Name of the file to be created(Need not be the name of the file on FTP server).>>
                if (!Directory.Exists(localPath))
                {
                    Directory.CreateDirectory(localPath);
                }
                FileStream outputStream = new FileStream(localPath + "\\" + fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + ftpFilePath));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (System.Net.WebException we)
            {
                //throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        public static void DownloadFile(string localPath, string saveName, string ftpFilePath, ProgressBar progBar, Label lblProgress)
        {
            try
            {
                //Create FTP request
                FtpWebRequest request = FtpWebRequest.Create(ftpServerPath + "/" + ftpFilePath) as FtpWebRequest;

                //Get the file size first (for progress bar)
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true; //don't close the connection

                int dataLength = (int)request.GetResponse().ContentLength;
                int value = 0;

                //Now get the actual data
                request = FtpWebRequest.Create(ftpServerPath + "/" + ftpFilePath) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false; //close the connection when done

                //Set up progress bar
                if (progBar != null)
                {
                    progBar.Value = 0;
                    progBar.Maximum = dataLength;
                }
                if (lblProgress != null)
                {
                    lblProgress.Text = "0/" + dataLength.ToString();
                }
                

                //Streams
                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream reader = response.GetResponseStream();

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                FileStream fileStream = new FileStream(localPath + "\\" + saveName, FileMode.Create);
                byte[] buffer = new byte[1024]; //downloads in chuncks

                while (true)
                {
                    Application.DoEvents(); //prevent application from crashing

                    //Try to read the data
                    int bytesRead = reader.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        //Nothing was read, finished downloading
                        if(progBar != null)
                            progBar.Value = progBar.Maximum;
                        if(lblProgress != null)
                            lblProgress.Text = FormatBytes(dataLength) + "/" + FormatBytes(dataLength);

                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        fileStream.Write(buffer, 0, bytesRead);

                        //Update the progress bar
                        if (value + bytesRead <= dataLength)
                        {
                            value += bytesRead;
                            if (progBar != null)
                            {
                                progBar.Value = value;
                                progBar.Refresh();
                            }
                            if (lblProgress != null)
                                lblProgress.Text = FormatBytes(value) + "/" + FormatBytes(dataLength);

                            Application.DoEvents();
                        }
                    }
                }

                //Clean up
                reader.Close();
                fileStream.Close();
                response.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DeleteFile(string filePath)
        {
            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + filePath));

                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
                return true;
            }            
            catch 
            {
                return false;
            }
        }

        public static string[] GetFilesDetailList()
        {
            try
            {
                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/"));
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }

                result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
                //MessageBox.Show(result.ToString().Split('\n'));
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string[] GetFileList()
        {
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/"));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                //MessageBox.Show(response.StatusDescription);
                return result.ToString().Split('\n');
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool HasChild(string path)
        {
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + path));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();

                if (line != "")
                {
                    return true;
                }
                else
                    return false;
            }            
            catch
            {
                return false;
            }
        }

        public static string[] GetContentList(string path)
        {
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            WebResponse response = null;
            StreamReader reader = null;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + path));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                response = reqFTP.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line.Split('/')[1]);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch
            {
                return null;
            }            
        }

        public static string[] GetFilesDetailList(string path)
        {
            try
            {

                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + path));
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }

                result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long GetFileSize(string filePath)
        {
            FtpWebRequest reqFTP;
            long fileSize = 0;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + filePath));
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                fileSize = response.ContentLength;

                ftpStream.Close();
                response.Close();
            }
            catch
            {
                fileSize = 0;
            }
           
            return fileSize;
        }

        public static string GetDateModified(string filePath)
        {
            FtpWebRequest reqFTP;
            string date = "";
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(ftpServerPath + "/" + filePath);
                reqFTP.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                date = response.LastModified.ToString("dd/MM/yyyy");

                ftpStream.Close();
                response.Close();
            }
            catch
            {
                date = "";
            }

            return date;
        }

        /// <summary>
        /// Đổi tên đường dẫn (file hoặc folder)
        /// </summary>
        /// <param name="currentFilename">Đường dẫn hiện tại</param>
        /// <param name="newFilename">Tên file hoặc folder mới</param>
        public static void Rename(string currentFilename, string newFilename)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + currentFilename));
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFilename;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void MakeDir(string dirName)
        {
            FtpWebRequest reqFTP;
            try
            {
                // dirName = name of the directory to create.
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + dirName));
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RemoveDir(string dirName)
        {
            FtpWebRequest reqFTP;
            try
            {
                // dirName = name of the directory to create.
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + dirName));
                reqFTP.Method = WebRequestMethods.Ftp.RemoveDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Kiểm tra sự tồn tại của đường dẫn trên server FTP
        /// </summary>
        /// <param name="path">Đường dẫn cần kiểm tra</param>
        /// <returns></returns>
        public static bool CheckExits(string path)
        {
            bool isExist = true;
            
            try
            {
                FtpWebRequest request = FtpWebRequest.Create(ftpServerPath + "/" + path) as FtpWebRequest;
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
            }
            catch 
            {
                isExist = false;
            }
            return isExist;
        }

        public static string[] GetFoldersList(string path)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + path));
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {                    
                    if (line.StartsWith("d"))
                    {
                        string[] array = line.Split(' ');
                        string childPath = array[array.Length - 1];
                        result.Append(childPath);
                        result.Append("\n");
                    }
                    line = reader.ReadLine();
                }

                result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (System.Net.WebException we)
            {
                throw new Exception(GetErrMsg(we));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string[] GetFilesList(string path)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + path));
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    string childPath = line.Split(' ')[line.Split(' ').Length - 1];
                    if (line.StartsWith("-"))
                    {
                        result.Append(childPath);
                        result.Append("\n");
                    }
                    line = reader.ReadLine();
                }

                result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch 
            {
                return null;
            }            
        }

        /// <summary>
        /// Lấy tất cả file trong một thư mục trên FTP trả về dạng bảng
        /// </summary>
        /// <param name="path">Thư mục đích</param>
        /// <returns></returns>
        public static DataTable GetFilesTable(string path)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("check", typeof(bool));
                dt.Columns.Add("FileName");
                dt.Columns.Add("Size");
                dt.Columns.Add("CreatedDate");
                dt.Columns.Add("FullPath");

                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerPath + "/" + path));
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line.StartsWith("-"))
                    {
                        string[] array1 = line.Split(' ');
                        string[] array = line.Split(':');
                        string childPath = array[1].Substring(2, array[1].Length - 2).Trim();
                        string size = array[0].Split(' ')[array[0].Split(' ').Length - 4];
                        DataRow row = dt.NewRow();
                        row[0] = false;
                        row[1] = childPath;
                        row[2] = size;
                        row[3] = "";// GetFileDate(path + "/" + childPath).ToString("dd/MM/yyyy");
                        row[4] = path + "/" + childPath;
                        dt.Rows.Add(row);
                    }
                    line = reader.ReadLine();
                }

                reader.Close();
                response.Close();
                return dt;
            }
           
            catch 
            {
                return new DataTable();
            }
        }

        #endregion

        public static void UploadDirectory(string dirPath, string ftpPath)
        {
            string[] files = Directory.GetFiles(dirPath, "*.*");
            string[] subDirs = Directory.GetDirectories(dirPath);

            if (files != null)
            {
                foreach (string file in files)
                {
                    UploadFile(file, ftpPath);
                }
            }

            if (subDirs != null)
            {
                foreach (string subDir in subDirs)
                {
                    MakeDir(ftpPath + "/" + Path.GetFileName(subDir));
                    UploadDirectory(subDir, ftpPath + "/" + Path.GetFileName(subDir));
                }
            }            
        }

        public static void DeleteDirectory(string ftpPath)
        {
            string[] files = GetContentList(ftpPath);
            if (files != null)
            {
                foreach (string filePath in files)
                {
                    bool isDeleted = DeleteFile(ftpPath + "/" + filePath);
                    if (!isDeleted)
                    {
                        DeleteDirectory(ftpPath + "/" + filePath);
                    }
                }
            }

            RemoveDir(ftpPath);
        }
    }
}
