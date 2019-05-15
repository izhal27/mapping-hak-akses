-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2019 at 04:53 AM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mapping_hak_akses`
--

-- --------------------------------------------------------

--
-- Table structure for table `form_action`
--

CREATE TABLE `form_action` (
  `form_name` varchar(100) NOT NULL,
  `form_text` varchar(100) DEFAULT NULL,
  `act_1` varchar(50) DEFAULT NULL,
  `act_2` varchar(50) DEFAULT NULL,
  `act_3` varchar(50) DEFAULT NULL,
  `act_4` varchar(50) DEFAULT NULL,
  `act_5` varchar(50) DEFAULT NULL,
  `act_6` varchar(50) DEFAULT NULL,
  `act_7` varchar(50) DEFAULT NULL,
  `act_8` varchar(50) DEFAULT NULL,
  `act_9` varchar(50) DEFAULT NULL,
  `act_10` varchar(50) DEFAULT NULL,
  `act_11` varchar(50) DEFAULT NULL,
  `act_12` varchar(50) DEFAULT NULL,
  `act_13` varchar(50) DEFAULT NULL,
  `act_14` varchar(50) DEFAULT NULL,
  `act_15` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `form_action`
--

INSERT INTO `form_action` (`form_name`, `form_text`, `act_1`, `act_2`, `act_3`, `act_4`, `act_5`, `act_6`, `act_7`, `act_8`, `act_9`, `act_10`, `act_11`, `act_12`, `act_13`, `act_14`, `act_15`) VALUES
('FrmHakAkses', 'Hak Akses', 'Update', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('FrmOperator', 'Operator', 'Tambah', 'Ubah', 'Hapus', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('FrmSubMenu1', 'Sub Menu - 1', 'Button - 1', 'Button - 2', 'Button - 3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('FrmSubMenu2', 'Sub Menu - 2', 'Button - 1', 'Button - 2', 'Button - 3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('FrmSubMenu3', 'Sub Menu - 3', 'Button - 1', 'Button - 2', 'Button - 3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('FrmSubMenu4', 'Sub Menu - 4', 'Button - 1', 'Button - 2', 'Button - 3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `operator`
--

CREATE TABLE `operator` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(150) DEFAULT '',
  `hp` varchar(50) DEFAULT '',
  `login_id` varchar(100) CHARACTER SET utf8 NOT NULL,
  `password` varchar(255) CHARACTER SET utf8 NOT NULL,
  `role_kode` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `operator`
--

INSERT INTO `operator` (`id`, `nama`, `alamat`, `hp`, `login_id`, `password`, `role_kode`) VALUES
(1, 'Administrator', '', '', 'admin', '1000:ET9z/DWhoKVmwhr7qGiperqNkovLlV3O:C5RHF4KmvXbixtE2BPR1YqCoEo0fjiPe', 'adm'),
(2, 'Operator - 1', '', '', 'op1', '1000:pOEZ3AkkF9u7x3FaV2TPEQoVQ6l2mZlc:H9IrI/YTOeNiq6M9vm1V7BJuSvwQRzeZ', 'ksr'),
(3, 'Operator - 2', '', '', 'op2', '1000:Bmo53ExGcbXVpSqba+Y1PkYctbtHzQoP:7H3CYVbkZXTQcNTTVcaG4Z2E2w361pvJ', 'ksr'),
(4, 'Operator - 3', '', '', 'op3', '1000:b7QRQgc8GZPJnQ8PSe75QqpeXIw6wNIC:sbsvFts8iHRuyiEXUEVjJtKQ/8PWoxrE', 'ksr');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id` int(10) UNSIGNED NOT NULL,
  `kode` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `keterangan` varchar(150) DEFAULT NULL,
  `created_by` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `kode`, `nama`, `keterangan`, `created_by`) VALUES
(1, 'adm', 'Administrator', '', 1),
(2, 'ksr', 'Kasir', '', 1),
(3, 'op', 'Operator', '', 1);

-- --------------------------------------------------------

--
-- Table structure for table `role_detail`
--

CREATE TABLE `role_detail` (
  `role_kode` varchar(20) NOT NULL,
  `menu_name` varchar(100) NOT NULL,
  `menu_parent` varchar(100) DEFAULT NULL,
  `form_action` varchar(100) DEFAULT NULL,
  `tag` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role_detail`
--

INSERT INTO `role_detail` (`role_kode`, `menu_name`, `menu_parent`, `form_action`, `tag`) VALUES
('adm', 'Button - 1', 'Menu - 3', 'FrmSubMenu3', 'action'),
('adm', 'Button - 2', 'Menu - 3', 'FrmSubMenu3', 'action'),
('adm', 'Button - 3', 'Menu - 3', 'FrmSubMenu3', 'action'),
('adm', 'Button - 1', 'Menu - 2', 'FrmSubMenu2', 'action'),
('adm', 'Button - 2', 'Menu - 2', 'FrmSubMenu2', 'action'),
('adm', 'Button - 3', 'Menu - 2', 'FrmSubMenu2', 'action'),
('adm', 'Button - 1', 'Menu - 3', 'FrmSubMenu4', 'action'),
('adm', 'Button - 2', 'Menu - 3', 'FrmSubMenu4', 'action'),
('adm', 'Button - 3', 'Menu - 3', 'FrmSubMenu4', 'action'),
('adm', 'Update', 'Master', 'FrmHakAkses', 'action'),
('adm', 'Tambah', 'Master', 'FrmHakAkses', 'action'),
('adm', 'Ubah', 'Master', 'FrmHakAkses', 'action'),
('adm', 'Hapus', 'Master', 'FrmHakAkses', 'action'),
('adm', 'Tambah', 'Master', 'FrmOperator', 'action'),
('adm', 'Ubah', 'Master', 'FrmOperator', 'action'),
('adm', 'Hapus', 'Master', 'FrmOperator', 'action'),
('adm', 'Button - 1', 'Menu - 1', 'FrmSubMenu1', 'action'),
('adm', 'Button - 2', 'Menu - 1', 'FrmSubMenu1', 'action'),
('adm', 'Button - 3', 'Menu - 1', 'FrmSubMenu1', 'action'),
('adm', 'Master', 'Master', NULL, 'menu'),
('adm', 'FrmOperator', 'Master', NULL, 'menuForm'),
('adm', 'FrmHakAkses', 'Master', NULL, 'menuForm'),
('adm', 'Menu - 1', 'Menu - 1', NULL, 'menu'),
('adm', 'FrmSubMenu1', 'Menu - 1', NULL, 'menuForm'),
('adm', 'Sub Menu - 1.2', 'Menu - 1', NULL, 'menu'),
('adm', 'Sub Menu - 1.3', 'Menu - 1', NULL, 'menu'),
('adm', 'Menu - 2', 'Menu - 2', NULL, 'menu'),
('adm', 'FrmSubMenu2', 'Menu - 2', NULL, 'menuForm'),
('adm', 'Sub Menu - 2.2', 'Menu - 2', NULL, 'menu'),
('adm', 'Sub Menu - 2.3', 'Menu - 2', NULL, 'menu'),
('adm', 'Menu - 3', 'Menu - 3', NULL, 'menu'),
('adm', 'FrmSubMenu3', 'Menu - 3', NULL, 'menuForm'),
('adm', 'Sub Menu - 3.2', 'Menu - 3', NULL, 'menu'),
('adm', 'Sub Menu - 3.3', 'Menu - 3', NULL, 'menu'),
('adm', 'Menu - 4', 'Menu - 3', NULL, 'menu'),
('adm', 'FrmSubMenu4', 'Menu - 3', NULL, 'menuForm'),
('adm', 'Sub Menu - 4.2', 'Menu - 3', NULL, 'menu'),
('adm', 'Sub Menu - 4.3', 'Menu - 3', NULL, 'menu');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `form_action`
--
ALTER TABLE `form_action`
  ADD UNIQUE KEY `form_name_UNIQUE` (`form_name`),
  ADD KEY `form_name` (`form_name`);

--
-- Indexes for table `operator`
--
ALTER TABLE `operator`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `login_id_UNIQUE` (`login_id`),
  ADD KEY `fk_user_role_role_kode` (`role_kode`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `kode` (`kode`);

--
-- Indexes for table `role_detail`
--
ALTER TABLE `role_detail`
  ADD KEY `fk_role_detail_role_kode_idx` (`role_kode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `operator`
--
ALTER TABLE `operator`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `operator`
--
ALTER TABLE `operator`
  ADD CONSTRAINT `fk_operator_role_role_kode` FOREIGN KEY (`role_kode`) REFERENCES `role` (`kode`) ON UPDATE CASCADE;

--
-- Constraints for table `role_detail`
--
ALTER TABLE `role_detail`
  ADD CONSTRAINT `fk_role_detail_role_kode` FOREIGN KEY (`role_kode`) REFERENCES `role` (`kode`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
