-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 05 Nov 2020 pada 16.36
-- Versi server: 10.4.13-MariaDB
-- Versi PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `apl_penggajian`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_akun`
--

CREATE TABLE `tb_akun` (
  `id` int(50) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_akun`
--

INSERT INTO `tb_akun` (`id`, `nama`, `email`, `username`, `password`) VALUES
(1, 'Akbar', 'admin@gmail.com', 'admin', 'admin'),
(2, 'rizki', 'rizki@gmail.com', 'akbar', 'akbar');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pegawai`
--

CREATE TABLE `tb_pegawai` (
  `id` int(30) NOT NULL,
  `nip` varchar(50) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `jenis_kelamin` varchar(30) NOT NULL,
  `alamat` text NOT NULL,
  `no_rek` varchar(50) NOT NULL,
  `jabatan` varchar(50) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `gaji_pokok` int(100) NOT NULL,
  `uang_lembur` int(100) NOT NULL,
  `potongan` int(100) NOT NULL,
  `gaji_total` int(100) NOT NULL,
  `tgl_transfer` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pegawai`
--

INSERT INTO `tb_pegawai` (`id`, `nip`, `nama`, `jenis_kelamin`, `alamat`, `no_rek`, `jabatan`, `tgl_masuk`, `gaji_pokok`, `uang_lembur`, `potongan`, `gaji_total`, `tgl_transfer`) VALUES
(8, '10001', 'iqbal', 'Laki-laki', 'Jakarta', '2321314', 'Teknisi', '2020-11-05', 5000000, 1000000, 250000, 5750000, '2020-11-05'),
(11, '10002', 'Danang', 'Laki-laki', 'Bekasi', '4123123', 'Teknisi', '2020-11-05', 6000000, 600000, 50000, 6550000, '2020-11-05');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_akun`
--
ALTER TABLE `tb_akun`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tb_pegawai`
--
ALTER TABLE `tb_pegawai`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nip` (`nip`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_akun`
--
ALTER TABLE `tb_akun`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `tb_pegawai`
--
ALTER TABLE `tb_pegawai`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
