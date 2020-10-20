SELECT * FROM kutuphane_db.adresler;

SELECT uyeler.ad,uyeler.soyad,uyeler.telefon 
	FROM uyeler 
    LEFT JOIN adresler 
    ON uyeler.uyeID=adresler.adresID