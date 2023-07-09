using System.ComponentModel;

namespace GeneratingQRCode.Models
{
    public class QRCodeModel
    {
        [DisplayName("Enter QRCode Text")]
        public string? QRCodeText { get; set; }
    }
}
