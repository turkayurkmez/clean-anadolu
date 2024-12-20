using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /// <summary>
    /// Rapor oluşturmak için kullanılan sınıf
    /// </summary>
    public class ReportGenerator
    {

        //Amaç: verilen bir excel dosyasını okuyarak rapor oluşturmak....
        private string excelFilePath;

        /// <summary>
        /// Rapor oluşturucu nesnesini initialize eder.
        /// </summary>
        /// <param name="excelFilePath">Verilerin okunacağı excel dosyası</param>
        public ReportGenerator(string excelFilePath)
        {
            //1. excelFilePath dolu mu boş mu?
            //2. Dosya var mı yok mu?
            //3. Excel dosyası doğru formatta mı?

            ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath, nameof(excelFilePath));
            checkFileIsValid(excelFilePath);
            this.excelFilePath = excelFilePath;


        }

        /// <summary>
        /// Excel dosyasının geçerli olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="filePath">Excel dosyasının adresi</param>
        /// <returns></returns>
        bool isExcelFileValid(string filePath) => true;
        /// <summary>
        /// Dosyanın var olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="filePath">Aranacak dosya adı</param>
        /// <returns></returns>
        bool isFileExists(string filePath) => File.Exists(filePath);

        void checkFileIsValid(string filePath)
        {
            if (!isFileExists(filePath))
            {
                throw new FileNotFoundException("Excel dosyası bulunamadı!");
            }
            if (!isExcelFileValid(filePath))
            {
                throw new ArgumentException("Excel dosyası geçerli bir dosya değil!");
            }
        }

        /// <summary>
        /// Rapor oluşturur.
        /// </summary>
        /// <param name="reportOptions">Rapor için gereken ayarlar</param>
        public void CreateReport(ReportOptions reportOptions) 
        {
            //Bir fonksiyonun tüm parametreleri, tek bir objeye her zaman dönüşmeyebilir.

        }
    }
}