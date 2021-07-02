# Q1
1. IComparePermutation adında bir interface ve bu interface içinde iki stringi karşılaştıracak Compare adında bir method oluşturdum.
2. Yukarıdaki interface'i ComparePermutation class'ında implement ettim. 
3. Compare methodunda stringlerden herhangi bir tanesi null veya empty ise hata fırlattırdım. Karşılaştırabilmemiz için iki parametrede valid değer içermelidir.
4. Stringlerin permutationlarını strPermutationList1 ve strPermutationList2 listeleri içerisinde oluşturdum. 
5. Permutation oluşturan methodu gerekli araştırmalar sonucunda internet üzerindeki kaynaklardan elde ettim. "permute(string str, int lIndex, int rIndex, List<string> strList) methodu bu işlemi gerçekleştirir."
6. Uzunluğu kısa olan stringin permutationlarının daha uzun olan string içinde olup olmadığını kontrol edebilmek için ilk foreach'de küçük stringin permutationlarını döndüm.
7. İkinci foreach'de büyük olanı dönerek içinde olup olmadığını contains methodu ile kontrol ettim. 
8. İçermesi durumunda kullanıcıya True, aksi takdirde False bildirdim.
