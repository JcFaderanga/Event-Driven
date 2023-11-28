-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2023 at 03:06 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorysystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(20) NOT NULL,
  `category` varchar(20) NOT NULL,
  `price` decimal(11,2) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `category`, `price`, `quantity`) VALUES
(8912301, 'RAM PORK&BEANS', 'Canned Goods', 21.00, 73),
(8912302, 'RAM PORK&BEANS', 'Canned Goods', 30.25, 38),
(8912303, 'RAM PORK&BEANS', 'Canned Goods', 49.25, 72),
(8912304, 'ULAM KING', 'Canned Goods', 20.90, 42),
(8912305, 'DON PRIMO TUNA FLAKE', 'Canned Goods', 38.50, 96),
(8912306, 'DON PRIMO LECHON PAK', 'Canned Goods', 38.50, 52),
(8912307, 'DON PRIMO ESTOFADO', 'Canned Goods', 39.00, 71),
(8912308, 'SM CORNED TUNA', 'Canned Goods', 47.45, 1),
(8912309, 'SM CHILI CORNED TUNA', 'Canned Goods', 47.45, 91),
(8912310, 'SM TUNA PAELLA E-O', 'Canned Goods', 45.50, 53),
(8912311, 'SM CORNED TUNA', 'Canned Goods', 38.65, 89),
(8912312, 'SM CHILI CORNED TUNA', 'Canned Goods', 38.65, 86),
(8912313, 'SM CORNED TUNA', 'Canned Goods', 29.00, 64),
(8912314, 'SM CHILI CORNED TUNA', 'Canned Goods', 29.00, 63),
(8912315, 'SM CORNED TUNA E-O', 'Canned Goods', 29.00, 19),
(8912316, 'SM CHILI CORNED TUNA', 'Canned Goods', 29.00, 9),
(8912317, 'SM CT ADOBO', 'Canned Goods', 35.00, 84),
(8912318, 'SM CT AFRITADA', 'Canned Goods', 35.00, 95),
(8912319, 'SM SPANISH STYLE', 'Canned Goods', 38.65, 20),
(8912320, 'SM CT CALDERETA', 'Canned Goods', 35.00, 15),
(8912321, 'CDO CHICKEN FLAKES S', 'Canned Goods', 34.00, 15),
(8912322, 'CDO TUNA SEA QUEST F', 'Canned Goods', 36.00, 27),
(8912323, '555 TUNA HOT SPICY', 'Canned Goods', 31.85, 93),
(8912324, '555 TUNA FLAKES IN V', 'Canned Goods', 31.38, 84),
(8912325, 'CORN BEEF', 'Can goods', 40.00, 38),
(8912326, '', 'Can goods', 0.00, 0),
(8912327, 'testing', 'CANNED GOODS', 200.00, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8912328;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
