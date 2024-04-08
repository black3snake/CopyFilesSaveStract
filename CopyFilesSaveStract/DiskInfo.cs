using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CopyFilesSaveStract
{
    /// <summary>
    /// Предоставляет информацию о диске (как локальном, так и сетевом).
    /// </summary>
    public class DiskInfo
    {
        #region Закрытые переменные-члены
        private UInt64 freeBytesAvailableToCaller;
        private UInt64 totalBytes;
        private UInt64 totalFreeBytes;
        #endregion

        #region Открытые свойства
        /// <summary>
        /// Возвращает число байт, непосредственно доступных вызывающему потоку
        /// </summary>
        public decimal FreeBytesAvailableToCaller
        {
            get { return freeBytesAvailableToCaller; }
        }

        /// <summary>
        /// Возвращает общий объекм диска в байтах
        /// </summary>
        public decimal TotalBytes
        {
            get { return totalBytes; }
        }

        /// <summary>
        /// Возвращает объеем свободного места на диске в байтах
        /// </summary>
        public decimal TotalFreeBytes
        {
            get { return totalFreeBytes; }
        }
        #endregion

        /// <summary>
        /// Создает экземпляр объекта
        /// </summary>
        /// <param name="directoryName">
        /// Директория на требуемом диске (может быть в UNC).
        /// </param>
        public DiskInfo(string directoryName)
        {
            //
            // Получаем информацию
            NativeMethods.GetDiskFreeSpaceEx(directoryName, out freeBytesAvailableToCaller,
                out totalBytes, out totalFreeBytes);
        }
    }

    /// <summary>
    /// Методы WinAPI.
    /// </summary>
    internal sealed class NativeMethods
    {
        #region Импортируемые функции
        /// <summary>
        /// This function obtains the following information about the amount of space available 
        /// on a disk volume: the total amount of space, the total amount of free space, and the 
        /// amount of free space available to the user associated with the calling thread.
        /// </summary>
        /// <param name="lpDirectoryName">
        /// String that specifies a directory on the specified disk. This string can be a 
        /// Universal Naming Convention (UNC) name.
        /// </param>
        /// <param name="lpFreeBytesAvailable">
        /// Total number of free bytes on the disk that are available to the user associated 
        /// with the calling thread.
        /// </param>
        /// <param name="lpTotalNumberOfBytes">
        /// Total number of bytes on the disk that are available to the user associated with 
        /// the calling thread. 
        /// </param>
        /// <param name="lpTotalNumberOfFreeBytes">
        /// Total number of free bytes on the disk.
        /// </param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        internal static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
            out UInt64 lpFreeBytesAvailable, out UInt64 lpTotalNumberOfBytes,
            out UInt64 lpTotalNumberOfFreeBytes);
        #endregion

        /// <summary>
        /// Создает экземпляр объекта.
        /// </summary>
        private NativeMethods()
        {
        }
    }
}
