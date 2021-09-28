-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 17, 2020 at 08:36 PM
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
-- Database: `db2`
--

-- --------------------------------------------------------

--
-- Table structure for table `assignments`
--

CREATE TABLE `assignments` (
  `projid` smallint(5) UNSIGNED NOT NULL,
  `empno` smallint(5) UNSIGNED NOT NULL,
  `a_start_date` date DEFAULT NULL,
  `a_end_date` date DEFAULT NULL,
  `bill_rate` tinyint(4) NOT NULL,
  `assign_type` char(2) DEFAULT NULL,
  `hours` tinyint(3) UNSIGNED DEFAULT NULL
) ;

--
-- Dumping data for table `assignments`
--

INSERT INTO `assignments` (`projid`, `empno`, `a_start_date`, `a_end_date`, `bill_rate`, `assign_type`, `hours`) VALUES
(1, 7369, '2010-12-01', '2012-11-30', 50, 'WR', 15),
(1, 7902, '2011-07-01', '2013-12-31', 55, 'WR', 20),
(2, 7844, '2013-09-01', '2016-10-31', 45, 'PF', 30);

-- --------------------------------------------------------

--
-- Table structure for table `dept`
--

CREATE TABLE `dept` (
  `depno` tinyint(3) UNSIGNED NOT NULL,
  `dname` char(12) NOT NULL,
  `loc` char(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dept`
--

INSERT INTO `dept` (`depno`, `dname`, `loc`) VALUES
(10, 'Accounting', 'New York'),
(20, 'Research', 'Dallas'),
(30, 'Sales', 'Chicago'),
(40, 'Operations', 'Boston');

-- --------------------------------------------------------

--
-- Table structure for table `emp`
--

CREATE TABLE `emp` (
  `empno` smallint(5) UNSIGNED NOT NULL,
  `ename` char(12) NOT NULL,
  `job` char(12) NOT NULL,
  `mgr` smallint(5) UNSIGNED NOT NULL,
  `hiredate` date DEFAULT curdate(),
  `sal` decimal(8,2) DEFAULT NULL,
  `comm` decimal(8,2) DEFAULT NULL,
  `depno` tinyint(3) UNSIGNED NOT NULL
) ;

--
-- Dumping data for table `emp`
--

INSERT INTO `emp` (`empno`, `ename`, `job`, `mgr`, `hiredate`, `sal`, `comm`, `depno`) VALUES
(7369, 'Smith', 'Clerk', 7566, '2009-04-01', '1800.00', '0.00', 20),
(7499, 'Allen', 'Salesman', 7782, '2012-08-01', '1600.00', '1300.00', 30),
(7521, 'Ward', 'Salesman', 7782, '2000-01-01', '1250.00', '1500.00', 30),
(7566, 'Jones', 'Manager', 7839, '1999-10-01', '2975.00', '0.00', 20),
(7654, 'Martin', 'Salesman', 7782, '2010-06-01', '1250.00', '2400.00', 30),
(7698, 'Blake', 'Manager', 7839, '1999-08-01', '3850.00', '0.00', 30),
(7782, 'Clark', 'Manager', 7839, '2011-10-01', '3450.00', '0.00', 10),
(7788, 'Scott', 'Analyst', 7782, '2012-03-01', '3000.00', '0.00', 20),
(7839, 'King', 'President', 7839, '2001-01-01', '5000.00', '0.00', 10),
(7844, 'Turner', 'Salesman', 7782, '2015-02-01', '1500.00', '1500.00', 30),
(7876, 'Adams', 'Clerk', 7566, '2007-03-01', '1800.00', '0.00', 20),
(7900, 'James', 'Clerk', 7566, '2004-12-01', '1950.00', '0.00', 30),
(7902, 'Ford', 'Analyst', 7782, '2015-09-01', '3000.00', '0.00', 20),
(7934, 'Miller', 'Clerk', 7566, '2018-01-01', '1800.00', '0.00', 10);

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE `projects` (
  `projid` smallint(5) UNSIGNED NOT NULL,
  `p_desc` char(25) DEFAULT NULL,
  `p_start_date` date DEFAULT NULL,
  `p_end_date` date DEFAULT NULL,
  `budget_amount` decimal(7,2) DEFAULT NULL,
  `max_no_staff` tinyint(4) DEFAULT NULL,
  `comments` tinytext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `projects`
--

INSERT INTO `projects` (`projid`, `p_desc`, `p_start_date`, `p_end_date`, `budget_amount`, `max_no_staff`, `comments`) VALUES
(1, 'Hydro-geological study', '0000-00-00', '0000-00-00', '50000.00', 5, 'Start phase'),
(2, 'Project River-Bridge', '2013-04-10', '2016-02-28', '60000.00', 8, 'Start phase'),
(3, 'Project Highway W2', '2016-03-01', '2019-02-28', '60000.00', 7, '');

-- --------------------------------------------------------

--
-- Table structure for table `salgrade`
--

CREATE TABLE `salgrade` (
  `grade` tinyint(3) UNSIGNED NOT NULL,
  `losal` decimal(7,2) NOT NULL,
  `hisal` decimal(7,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salgrade`
--

INSERT INTO `salgrade` (`grade`, `losal`, `hisal`) VALUES
(1, '700.00', '1400'),
(2, '1401.00', '1600'),
(3, '1601.00', '2000'),
(4, '2001.00', '3000'),
(5, '3001.00', '9999');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assignments`
--
ALTER TABLE `assignments`
  ADD UNIQUE KEY `unq_key` (`projid`,`empno`),
  ADD KEY `empno` (`empno`);

--
-- Indexes for table `dept`
--
ALTER TABLE `dept`
  ADD PRIMARY KEY (`depno`);

--
-- Indexes for table `emp`
--
ALTER TABLE `emp`
  ADD PRIMARY KEY (`empno`),
  ADD KEY `depno_fr_key` (`depno`),
  ADD KEY `emp_mgr` (`mgr`);

--
-- Indexes for table `projects`
--
ALTER TABLE `projects`
  ADD PRIMARY KEY (`projid`);

--
-- Indexes for table `salgrade`
--
ALTER TABLE `salgrade`
  ADD PRIMARY KEY (`grade`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `assignments`
--
ALTER TABLE `assignments`
  ADD CONSTRAINT `assignments_ibfk_1` FOREIGN KEY (`projid`) REFERENCES `projects` (`projid`),
  ADD CONSTRAINT `assignments_ibfk_2` FOREIGN KEY (`empno`) REFERENCES `emp` (`empno`);

--
-- Constraints for table `emp`
--
ALTER TABLE `emp`
  ADD CONSTRAINT `depno_fr_key` FOREIGN KEY (`depno`) REFERENCES `dept` (`depno`),
  ADD CONSTRAINT `emp_mgr` FOREIGN KEY (`mgr`) REFERENCES `emp` (`empno`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
