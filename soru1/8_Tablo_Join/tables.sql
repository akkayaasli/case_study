SELECT * FROM kutuphane_db.uyeler;

SELECT uyeler.ad,uyeler.soyad,uyeler.telefon ,adresler.il,yayinevleri.yayinEviAdi,kitapAD,kitaplar_kutuphane.adet,kitapyazarlar.yazarlarID,yazarlar.yazarAd,yazarlar.yazarSoyad
	FROM uyeler , adresler,yayinevleri,kitaplar,kitaplar_kutuphane,kitapyazarlar,yazarlar
    WHERE  kitapyazarlar.yazarlarID=yazarlar.yazarlarID