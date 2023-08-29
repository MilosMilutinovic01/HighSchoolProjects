-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 30, 2020 at 02:20 PM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `rezervacija`
--

DROP TABLE IF EXISTS `rezervacija`;
CREATE TABLE IF NOT EXISTS `rezervacija` (
  `id` int(5) NOT NULL,
  `ime` varchar(45) NOT NULL,
  `email` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rezervacija`
--

INSERT INTO `rezervacija` (`id`, `ime`, `email`) VALUES
(4, 'Djordje Dragovic', 'murajsam@gmail.com'),
(25, 'Miroslav Petkovic', 'mirko@gmail.com'),
(50, 'Milenija Dubrocic', 'milen345@gmail.com'),
(51, 'Miodrag Pavic', 'miodrag@gmail.com'),
(2, 'Andjela Micic', 'andjela@gmail.com'),
(46, 'saasgag asgasgasg', 'asfagf@gmail.com'),
(49, 'Djojo Mojo', 'jojo@gmail.com'),
(8, 'Himi Pimi', 'imimi@gmail.com'),
(47, 'Ilip Milip', 'mip@gmail.com'),
(23, 'Hhuhu Puhu', 'puhu@gmail.com');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
