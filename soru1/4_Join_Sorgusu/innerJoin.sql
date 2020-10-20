SELECT * FROM kutuphane_db.uyeler;
SELECT uyeler.ad,uyeler.soyad,kitaplar.kitapAD
FROM uyeler
INNER JOIN kitaplar ON uyeler.uyeID = kitaplar.kitapID
