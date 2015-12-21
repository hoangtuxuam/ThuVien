namespace DTO
{
    using System;

    public class CT_PhieuMuon
    {
        public PhieuMuon phieuMuon { get; set; }

        public Sach sach { get; set; }

        public DateTime HanTra { get; set; }

        public CT_PhieuMuon()
        {
            sach = new Sach();
            phieuMuon = new PhieuMuon();
        }

    }
}
