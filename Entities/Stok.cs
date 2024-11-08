namespace Entities;
public class Stok : BaseObject
{
    public int ToplamStok { get; set; }
    public int KategoriID { get; set; }
    public int UrunID { get; set; }
    public Urun? Urun { get; set; }
    public Kategori? Kategori { get; set; }
}
