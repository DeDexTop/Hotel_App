-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 08, 2023 at 12:08 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id` int(11) NOT NULL,
  `id_transaksi` int(11) NOT NULL,
  `id_kamar` int(11) NOT NULL,
  `jumlah_kamar` int(11) NOT NULL,
  `checkin` date NOT NULL,
  `checkout` date NOT NULL,
  `harga` int(11) NOT NULL,
  `dibuat` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id`, `id_transaksi`, `id_kamar`, `jumlah_kamar`, `checkin`, `checkout`, `harga`, `dibuat`) VALUES
(1, 1, 1, 2, '2023-03-04', '2023-03-06', 800000, '2023-03-04'),
(2, 1, 1, 2, '2023-03-04', '2023-03-06', 800000, '2023-03-04'),
(3, 1, 3, 1, '2023-03-04', '2023-03-05', 400000, '2023-03-04'),
(4, 2, 1, 2, '2023-01-01', '2023-01-03', 800000, '2023-03-05'),
(5, 2, 4, 2, '2023-01-01', '2023-01-03', 2000000, '2023-03-05'),
(6, 3, 2, 3, '2023-01-01', '2023-01-03', 1800000, '2023-03-05'),
(7, 3, 1, 2, '2023-01-01', '2023-01-03', 800000, '2023-03-05'),
(8, 4, 2, 2, '2023-01-01', '2023-01-03', 1200000, '2023-03-05'),
(9, 4, 4, 2, '2023-01-01', '2023-01-03', 2000000, '2023-03-05'),
(10, 5, 3, 2, '2023-01-01', '2023-01-03', 1600000, '2023-03-05'),
(11, 5, 3, 2, '2023-01-01', '2023-01-03', 1600000, '2023-03-05'),
(12, 6, 1, 2, '2023-01-01', '2023-01-03', 800000, '2023-03-05'),
(13, 6, 2, 3, '2023-01-01', '2023-01-03', 1800000, '2023-03-05'),
(14, 7, 1, 2, '2023-03-09', '2023-03-11', 800000, '2023-03-06'),
(15, 7, 2, 2, '2023-03-09', '2023-03-11', 1200000, '2023-03-06'),
(16, 8, 2, 2, '2023-01-01', '2023-01-03', 1200000, '2023-03-06'),
(17, 8, 3, 2, '2023-01-01', '2023-01-03', 1600000, '2023-03-06'),
(18, 9, 3, 2, '2023-01-01', '2023-01-03', 1600000, '2023-03-06'),
(19, 9, 1, 2, '2023-01-01', '2023-01-03', 800000, '2023-03-06'),
(20, 10, 1, 2, '2023-03-30', '2023-04-01', 800000, '2023-03-06'),
(21, 10, 3, 2, '2023-03-30', '2023-04-01', 1600000, '2023-03-06'),
(22, 10, 4, 2, '2023-03-30', '2023-04-02', 3600000, '2023-03-06'),
(23, 10, 2, 4, '2023-03-30', '2023-04-01', 2400000, '2023-03-06'),
(24, 11, 1, 2, '2023-07-05', '2023-07-07', 800000, '2023-03-06'),
(25, 11, 3, 2, '2023-07-05', '2023-07-07', 1600000, '2023-03-06'),
(26, 12, 1, 1, '2023-01-01', '2023-01-02', 200000, '2023-03-07'),
(27, 13, 1, 2, '2023-01-01', '2023-01-03', 800000, '2023-03-07'),
(28, 14, 4, 1, '2023-01-01', '2023-01-02', 600000, '2023-03-07'),
(29, 15, 2, 2, '2023-01-01', '2023-01-03', 1200000, '2023-03-07'),
(30, 15, 1, 2, '2023-01-01', '2023-01-03', 800000, '2023-03-07');

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

CREATE TABLE `log` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `activity` text NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `log`
--

INSERT INTO `log` (`id`, `id_user`, `activity`, `date`) VALUES
(1, 1, 'Logout', '2023-03-04'),
(2, 1, 'Login', '2023-03-04'),
(3, 1, 'Logout', '2023-03-04'),
(4, 1, 'Login', '2023-03-04'),
(5, 1, 'input data karyawan', '2023-03-04'),
(6, 1, 'input data karyawan', '2023-03-04'),
(7, 1, 'mengubah data karyawan', '2023-03-04'),
(8, 1, 'Logout', '2023-03-04'),
(9, 1, 'Login', '2023-03-04'),
(10, 1, 'input data kamar', '2023-03-04'),
(11, 1, 'Logout', '2023-03-04'),
(12, 1, 'Login', '2023-03-04'),
(13, 1, 'input data kamar', '2023-03-04'),
(14, 1, 'input data kamar', '2023-03-04'),
(15, 1, 'input data kamar', '2023-03-04'),
(16, 1, 'Logout', '2023-03-04'),
(17, 3, 'Logout', '2023-03-04'),
(18, 3, 'Login', '2023-03-04'),
(19, 3, 'input data transaksi', '2023-03-04'),
(20, 3, 'Logout', '2023-03-04'),
(21, 2, 'Login', '2023-03-04'),
(22, 2, 'Logout', '2023-03-04'),
(23, 2, 'Login', '2023-03-04'),
(24, 2, 'Logout', '2023-03-04'),
(25, 2, 'Login', '2023-03-04'),
(26, 2, 'Logout', '2023-03-04'),
(27, 2, 'Login', '2023-03-04'),
(28, 2, 'Logout', '2023-03-04'),
(29, 2, 'Login', '2023-03-04'),
(30, 2, 'Logout', '2023-03-04'),
(31, 2, 'Login', '2023-03-04'),
(32, 2, 'Logout', '2023-03-04'),
(33, 2, 'Login', '2023-03-04'),
(34, 2, 'Logout', '2023-03-04'),
(35, 2, 'Login', '2023-03-04'),
(36, 2, 'Logout', '2023-03-04'),
(37, 2, 'Login', '2023-03-04'),
(38, 2, 'Logout', '2023-03-04'),
(39, 2, 'Login', '2023-03-04'),
(40, 2, 'Logout', '2023-03-04'),
(41, 2, 'Login', '2023-03-04'),
(42, 2, 'Logout', '2023-03-04'),
(43, 2, 'Login', '2023-03-04'),
(44, 2, 'Logout', '2023-03-04'),
(45, 2, 'Login', '2023-03-04'),
(46, 2, 'Logout', '2023-03-04'),
(47, 2, 'Login', '2023-03-04'),
(48, 2, 'Logout', '2023-03-04'),
(49, 2, 'Login', '2023-03-04'),
(50, 2, 'Logout', '2023-03-04'),
(51, 2, 'Login', '2023-03-04'),
(52, 2, 'Login', '2023-03-04'),
(53, 2, 'Logout', '2023-03-04'),
(54, 2, 'Login', '2023-03-04'),
(55, 2, 'Logout', '2023-03-04'),
(56, 2, 'Login', '2023-03-04'),
(57, 2, 'Logout', '2023-03-04'),
(58, 2, 'Login', '2023-03-04'),
(59, 2, 'Logout', '2023-03-04'),
(60, 2, 'Login', '2023-03-04'),
(61, 2, 'Logout', '2023-03-04'),
(62, 2, 'Login', '2023-03-04'),
(63, 2, 'Logout', '2023-03-04'),
(64, 2, 'Login', '2023-03-04'),
(65, 2, 'Logout', '2023-03-04'),
(66, 2, 'Login', '2023-03-05'),
(67, 2, 'Logout', '2023-03-05'),
(68, 2, 'Login', '2023-03-05'),
(69, 2, 'Logout', '2023-03-05'),
(70, 2, 'Login', '2023-03-05'),
(71, 2, 'Logout', '2023-03-05'),
(72, 2, 'Login', '2023-03-05'),
(73, 2, 'Logout', '2023-03-05'),
(74, 2, 'Login', '2023-03-05'),
(75, 2, 'Logout', '2023-03-05'),
(76, 2, 'Login', '2023-03-05'),
(77, 2, 'Logout', '2023-03-05'),
(78, 2, 'Login', '2023-03-05'),
(79, 2, 'Logout', '2023-03-05'),
(80, 2, 'Login', '2023-03-05'),
(81, 2, 'Logout', '2023-03-05'),
(82, 2, 'Login', '2023-03-05'),
(83, 2, 'Logout', '2023-03-05'),
(84, 2, 'Login', '2023-03-05'),
(85, 2, 'Logout', '2023-03-05'),
(86, 2, 'Login', '2023-03-05'),
(87, 2, 'Logout', '2023-03-05'),
(88, 2, 'Login', '2023-03-05'),
(89, 2, 'Logout', '2023-03-05'),
(90, 2, 'Login', '2023-03-05'),
(91, 2, 'Logout', '2023-03-05'),
(92, 2, 'Login', '2023-03-05'),
(93, 2, 'Login', '2023-03-05'),
(94, 2, 'Login', '2023-03-05'),
(95, 2, 'Login', '2023-03-05'),
(96, 2, 'Logout', '2023-03-05'),
(97, 1, 'Login', '2023-03-05'),
(98, 1, 'Logout', '2023-03-05'),
(99, 3, 'Login', '2023-03-05'),
(100, 3, 'Logout', '2023-03-05'),
(101, 2, 'Login', '2023-03-05'),
(102, 2, 'Logout', '2023-03-05'),
(103, 2, 'Login', '2023-03-05'),
(104, 2, 'Login', '2023-03-05'),
(105, 2, 'Logout', '2023-03-05'),
(106, 2, 'Login', '2023-03-05'),
(107, 2, 'Logout', '2023-03-05'),
(108, 2, 'Login', '2023-03-05'),
(109, 2, 'Logout', '2023-03-05'),
(110, 2, 'Login', '2023-03-05'),
(111, 2, 'Logout', '2023-03-05'),
(112, 2, 'Login', '2023-03-05'),
(113, 2, 'Logout', '2023-03-05'),
(114, 2, 'Login', '2023-03-05'),
(115, 2, 'Logout', '2023-03-05'),
(116, 2, 'Login', '2023-03-05'),
(117, 2, 'Logout', '2023-03-05'),
(118, 3, 'Login', '2023-03-05'),
(119, 3, 'input data transaksi', '2023-03-05'),
(120, 3, 'Logout', '2023-03-05'),
(121, 3, 'Login', '2023-03-05'),
(122, 3, 'input data transaksi', '2023-03-05'),
(123, 3, 'Logout', '2023-03-05'),
(124, 2, 'Login', '2023-03-05'),
(125, 2, 'Logout', '2023-03-05'),
(126, 3, 'Login', '2023-03-05'),
(127, 3, 'input data transaksi', '2023-03-05'),
(128, 3, 'Logout', '2023-03-05'),
(129, 3, 'Login', '2023-03-05'),
(130, 3, 'input data transaksi', '2023-03-05'),
(131, 3, 'input data transaksi', '2023-03-05'),
(132, 3, 'Logout', '2023-03-05'),
(133, 2, 'Login', '2023-03-05'),
(134, 2, 'Logout', '2023-03-05'),
(135, 2, 'Login', '2023-03-06'),
(136, 2, 'Logout', '2023-03-06'),
(137, 3, 'Login', '2023-03-06'),
(138, 3, 'input data transaksi', '2023-03-06'),
(139, 3, 'input data transaksi', '2023-03-06'),
(140, 3, 'Logout', '2023-03-06'),
(141, 3, 'Login', '2023-03-06'),
(142, 3, 'input data transaksi', '2023-03-06'),
(143, 3, 'Logout', '2023-03-06'),
(144, 2, 'Login', '2023-03-06'),
(145, 2, 'Logout', '2023-03-06'),
(146, 1, 'Login', '2023-03-06'),
(147, 1, 'input data karyawan', '2023-03-06'),
(148, 1, 'mengubah data kamar', '2023-03-06'),
(149, 1, 'Logout', '2023-03-06'),
(150, 2, 'Login', '2023-03-06'),
(151, 2, 'Logout', '2023-03-06'),
(152, 2, 'Login', '2023-03-06'),
(153, 2, 'Logout', '2023-03-06'),
(154, 3, 'Login', '2023-03-06'),
(155, 3, 'input data transaksi', '2023-03-06'),
(156, 3, 'Logout', '2023-03-06'),
(157, 3, 'Login', '2023-03-06'),
(158, 3, 'Logout', '2023-03-06'),
(159, 1, 'Login', '2023-03-06'),
(160, 1, 'Logout', '2023-03-06'),
(161, 1, 'Login', '2023-03-06'),
(162, 1, 'mengubah data karyawan', '2023-03-06'),
(163, 1, 'Logout', '2023-03-06'),
(164, 1, 'Login', '2023-03-06'),
(165, 1, 'Logout', '2023-03-06'),
(166, 3, 'Login', '2023-03-06'),
(167, 3, 'Login', '2023-03-06'),
(168, 3, 'input data transaksi', '2023-03-06'),
(169, 3, 'Logout', '2023-03-06'),
(170, 1, 'Login', '2023-03-07'),
(171, 1, 'input data karyawan', '2023-03-07'),
(172, 1, 'mengubah data karyawan', '2023-03-07'),
(173, 1, 'menghapus data karyawan', '2023-03-07'),
(174, 1, 'Logout', '2023-03-07'),
(177, 3, 'Login', '2023-03-07'),
(178, 3, 'input data transaksi', '2023-03-07'),
(179, 3, 'Logout', '2023-03-07'),
(180, 3, 'Login', '2023-03-07'),
(181, 3, 'input data transaksi', '2023-03-07'),
(182, 3, 'Logout', '2023-03-07'),
(183, 3, 'Login', '2023-03-07'),
(184, 3, 'input data transaksi', '2023-03-07'),
(185, 1, 'Login', '2023-03-07'),
(186, 1, 'menghapus data karyawan', '2023-03-07'),
(187, 1, 'Logout', '2023-03-07'),
(188, 2, 'Login', '2023-03-07'),
(189, 2, 'Logout', '2023-03-07'),
(190, 3, 'Login', '2023-03-07'),
(191, 3, 'input data transaksi', '2023-03-07'),
(192, 3, 'Logout', '2023-03-07'),
(193, 3, 'Login', '2023-03-07'),
(194, 3, 'Logout', '2023-03-07'),
(195, 3, 'Login', '2023-03-07'),
(196, 3, 'Logout', '2023-03-07'),
(197, 1, 'Login', '2023-03-08'),
(198, 1, 'input data karyawan', '2023-03-08'),
(199, 1, 'menghapus data karyawan', '2023-03-08'),
(200, 1, 'input data kamar', '2023-03-08'),
(201, 1, 'Logout', '2023-03-08'),
(202, 3, 'Login', '2023-03-08'),
(203, 3, 'Logout', '2023-03-08');

-- --------------------------------------------------------

--
-- Table structure for table `tb_kamar`
--

CREATE TABLE `tb_kamar` (
  `id` int(11) NOT NULL,
  `tipe_kamar` varchar(45) NOT NULL,
  `harga_per_malam` int(11) NOT NULL,
  `gambar` varchar(255) NOT NULL,
  `dibuat` date NOT NULL,
  `diupdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_kamar`
--

INSERT INTO `tb_kamar` (`id`, `tipe_kamar`, `harga_per_malam`, `gambar`, `dibuat`, `diupdate`) VALUES
(1, 'Original', 200000, 'Original.png', '2023-03-04', NULL),
(2, 'Deluxe', 300000, 'Deluxe.png', '2023-03-04', NULL),
(3, 'Premium', 400000, 'Premium.png', '2023-03-04', NULL),
(4, 'VIP', 600000, 'VIP.png', '2023-03-04', '2023-03-06'),
(5, 'Classic', 90000, 'Classic.png', '2023-03-08', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tb_transaksi`
--

CREATE TABLE `tb_transaksi` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `nama_pelanggan` varchar(10) NOT NULL,
  `kode_transaksi` varchar(45) NOT NULL,
  `jumlah_kamar_dipesan` int(11) NOT NULL,
  `total_bayar` int(11) NOT NULL,
  `dibuat` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_transaksi`
--

INSERT INTO `tb_transaksi` (`id`, `id_user`, `nama_pelanggan`, `kode_transaksi`, `jumlah_kamar_dipesan`, `total_bayar`, `dibuat`) VALUES
(1, 3, 'Fauzan', '202303040000', 5, 2000000, '2023-03-04'),
(2, 3, 'Arief', '202303050001', 4, 2800000, '2023-03-05'),
(3, 3, 'Romy', '202303050002', 5, 2600000, '2023-03-05'),
(4, 3, 'Ridwan', '202303050003', 4, 3200000, '2023-03-05'),
(5, 3, 'Rafly', '202303050004', 4, 3200000, '2023-03-05'),
(6, 3, 'Aldi', '202303050005', 5, 2600000, '2023-03-05'),
(7, 3, 'Firza', '202303060006', 4, 2000000, '2023-03-06'),
(8, 3, 'Alghifari', '202303060007', 4, 2800000, '2023-03-06'),
(9, 3, 'Dina', '202303060008', 4, 2400000, '2023-03-06'),
(10, 3, 'Tania', '202303060009', 10, 8400000, '2023-03-06'),
(11, 3, 'Silvi', '202303060010', 4, 2400000, '2023-03-06'),
(12, 3, 'silvi', '202303070011', 1, 200000, '2023-03-07'),
(13, 3, 'Nuy', '202303070012', 2, 800000, '2023-03-07'),
(14, 3, 'ucu', '202303070013', 1, 600000, '2023-03-07'),
(15, 3, 'Udin', '202303070014', 4, 2000000, '2023-03-07');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `role` enum('admin','kasir','owner') NOT NULL,
  `dibuat` date NOT NULL,
  `diupdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `nama`, `role`, `dibuat`, `diupdate`) VALUES
(1, 'admin', 'admin123', 'Arief', 'admin', '2023-03-04', NULL),
(2, 'owner', 'owner123', 'Romy', 'owner', '2023-03-04', NULL),
(3, 'kasir', 'kasir123', 'Rizki', 'kasir', '2023-03-04', '2023-03-04');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_transaksi` (`id_transaksi`),
  ADD KEY `id_kamar` (`id_kamar`);

--
-- Indexes for table `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `tb_kamar`
--
ALTER TABLE `tb_kamar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `log`
--
ALTER TABLE `log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=204;

--
-- AUTO_INCREMENT for table `tb_kamar`
--
ALTER TABLE `tb_kamar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `tb_transaksi` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detail_transaksi_ibfk_2` FOREIGN KEY (`id_kamar`) REFERENCES `tb_kamar` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `log`
--
ALTER TABLE `log`
  ADD CONSTRAINT `log_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD CONSTRAINT `tb_transaksi_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
