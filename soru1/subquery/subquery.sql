SELECT yazarAd,yazarSoyad FROM yazarlar 
	WHERE yazarlarID=
		(SELECT yazarlarID
			FROM kitapyazarlar
			WHERE yazarlarID=
				(SELECT kitapID
					FROM kitaplar_kutuphane
                   				 WHERE kitapID=
						(SELECT kutuphaneID
							FROM kutuphane
                           						 WHERE kutuphaneID=1)))
