# Tubes2_13519156 Social Club
## Penjelasan singkat algoritma yang diimplementasikan
Berikut adalah langkah-langkah pemecahan masalah untuk fitur friend recommendation:
1.	Membaca masukan dari file berupa jumlah pertemanan dan daftar pertemanannya.
2.	Hasil pembacaan disertakan ke dalam GUI dan memberikan pilihan fitur.
3.	Menerima pilihan akun dari klik node, saat diklik akan melakukan pencarian rekomendasi teman.
4.	Hitung mutual friend dengan pendekatan yang menyerupai BFS:
a.	Menelusuri tetangga dari simpul akar kemudian buat list Teman dan buat map-to-set kosong. (penelusuran dari simpul akar ke simpul tingkat 1)
b.	Menelusuri tetangga dari simpul yang tadi dikunjungi, untuk setiap simpul, jika simpul tidak berada dalam Teman, menambahkan value (berupa parent simpul yang sedang ditinjau) ke dalam map sesuai dengan key (berupa simpul yang sedang ditinjau). (penelusuran dari simpul tingkat 1 ke tingkat 2)
c.	Diperoleh simpul yang terdiri dari banyak mutual friend dan apa saja terhadap simpul akar yang dipilih.
5.	Sort hasil yang diperoleh terurut dari mutual friend terbanyak, dari list hitung jumlah mutual friend kemudian buat list baru (dengan tipe yang sama), dan ambil list dengan ukuran terkecil terus menerus kemudian insertFirst ke list baru hingga kosong.
6.	Tampilkan simpul dengan mutual friend yang tidak nol beserta simpul apa saja sebagai mutual firend terhadap simpul akar.

Berikut adalah langkah-langkah pemecahan masalah untuk fitur explore friends:
1.	Membaca masukan dari file berupa jumlah pertemanan dan daftar pertemanannya.
2.	Hasil pembacaan disertakan ke dalam GUI dan memberikan pilihan fitur.
3.	Menerima pilihan eksplorasi dengan DFS atau BFS dan pilihan dua akun yang belum berteman
4.	Melakukan validasi apakah benar kedua akun belum berteman, jika sudah berteman masalah selesai
5.	Jika belum berteman, melakukan penelusuran dengan DFS/BFS kemudian memberikan jalur dari pengguna ke akun yang belum berteman

## Cara menggunakan program
-  Buka aplikasi Visual Studio
-  Pilih menu "Open a project or solution"
-  Pilih file solution (.sln) pada direktori source code
-  Klik tombol start untuk menjalankan program (akan memunculkan GUI)
-  Klik tombol browse kemudian pilih file input
-  Klik pilihan fitur yang ingin digunakan
-  Pilih algoritma yang ingin digunakan
-  Pilih simpul awal yang ingin ditelusuri
-  Jika memilih fitur explorefriends, pilih simpul tujuan
-  Klik submit maka program akan menampilkan solusi permasalahan

## Author / identitas pembuat
-  M. Abdi Haryadi. H / 13519156 / K-03
-  Rolland Steven Supardi / 13519173 / K-04
-  Muhammad Furqon / 13519184 / K-04
