SELECT * FROM kutuphane_db.yazarlar;

SELECT yazarlar.yazarAd,yazarlar.yazarSoyad 
	FROM yazarlar 
	RIGHT JOIN kitapyazarlar 
	ON yazarlar.yazarlarID=kitapyazarlar.yazarlarID;
    
    

    
