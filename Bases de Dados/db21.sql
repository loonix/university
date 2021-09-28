-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 26, 2020 at 08:26 PM
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
-- Database: `db21`
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
(2001, 'PEC', 'Pencil 3B', 500, '0.52'),
(2002, 'PEC', 'Pencil 4B', 200, '0.62'),
(2003, 'PEC', 'Pencil 5B', 100, '0.73'),
(2004, 'PEC', 'Pencil 6B', 500, '0.47'),
(2005, 'PEC', 'Pencil AA', 500, '0.45'),
(2006, 'PEC', 'Pencil AB', 500, '0.45');

-- --------------------------------------------------------

--
-- Table structure for table `products_suppliers`
--

CREATE TABLE `products_suppliers` (
  `productID` int(10) UNSIGNED NOT NULL,
  `suppID` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products_suppliers`
--

INSERT INTO `products_suppliers` (`productID`, `suppID`) VALUES
(2001, 501),
(2001, 503),
(2002, 501),
(2003, 501),
(2004, 502),
(2005, 502),
(2005, 503),
(2006, 502);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `suppID` int(4) UNSIGNED NOT NULL,
  `name` char(30) NOT NULL DEFAULT '',
  `phone` char(9) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`suppID`, `name`, `phone`) VALUES
(501, 'Paper & Office Supplies Co.', '123456789'),
(502, 'Books & School Ltd', '234567890'),
(503, 'Electronics Corp.', '345678901');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`productID`);

--
-- Indexes for table `products_suppliers`
--
ALTER TABLE `products_suppliers`
  ADD PRIMARY KEY (`productID`,`suppID`),
  ADD KEY `suppID` (`suppID`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`suppID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `productID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2007;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `suppID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=505;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `products_suppliers`
--
ALTER TABLE `products_suppliers`
  ADD CONSTRAINT `products_suppliers_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `products` (`productID`),
  ADD CONSTRAINT `products_suppliers_ibfk_2` FOREIGN KEY (`suppID`) REFERENCES `suppliers` (`suppID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
