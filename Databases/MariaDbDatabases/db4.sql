-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2020 at 09:45 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db4`
--

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `productID` int(10) UNSIGNED NOT NULL,
  `productCode` char(3) NOT NULL DEFAULT '',
  `name` varchar(30) NOT NULL DEFAULT '',
  `quantity` int(10) UNSIGNED NOT NULL DEFAULT 0,
  `price` decimal(7,2) NOT NULL DEFAULT 99.99
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`productID`, `productCode`, `name`, `quantity`, `price`) VALUES
(1001, 'PEN', 'Pen Red', 4900, '1.23'),
(1002, 'PEN', 'Pen Blue', 8000, '1.52'),
(1003, 'PEN', 'Pen Black', 2000, '1.52'),
(1004, 'PEC', 'Pencil 2B', 10000, '0.58'),
(1005, 'PEC', 'Pencil 2H', 8000, '0.59'),
(1006, 'NTB', 'Notebook A4L90p', 9000, '3.99'),
(1007, 'NTB', 'Notebook B5L60p', 8000, '3.39'),
(1008, 'NTB', 'Notebook A5L50p', 68500, '2.66'),
(1009, 'NTB', 'Notebook B6L40p', 68500, '2.42'),
(1010, 'PAP', 'Paper A4W80/500', 1000, '6.05'),
(1011, 'PAP', 'Paper A4E80/500', 1100, '5.93'),
(1012, 'RUB', 'Rubber white Soft', 1200, '2.41'),
(1013, 'RUB', 'Rubber color Medium', 1500, '1.20'),
(1014, 'DIG', 'iPad mini-4-Wi-Fi-128', 4, '494.99');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`productID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `productID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1015;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
