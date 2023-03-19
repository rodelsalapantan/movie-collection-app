-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 20, 2023 at 12:32 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movie_downloader_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

CREATE TABLE `history` (
  `id` int(11) NOT NULL,
  `movieid` int(11) NOT NULL,
  `userid` varchar(255) NOT NULL,
  `createdat` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `id` int(11) NOT NULL,
  `moviename` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `genre` varchar(255) NOT NULL,
  `actor` varchar(255) NOT NULL,
  `filesize` bigint(20) NOT NULL,
  `filelocation` varchar(255) NOT NULL,
  `portraitthumbnaillocation` varchar(255) NOT NULL,
  `landscapethumbnaillocation` varchar(255) NOT NULL,
  `downloadcount` int(11) NOT NULL DEFAULT 0,
  `ratings` double NOT NULL DEFAULT 0,
  `ratingscount` int(11) NOT NULL DEFAULT 0,
  `releasedate` date NOT NULL,
  `createdat` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`id`, `moviename`, `author`, `genre`, `actor`, `filesize`, `filelocation`, `portraitthumbnaillocation`, `landscapethumbnaillocation`, `downloadcount`, `ratings`, `ratingscount`, `releasedate`, `createdat`) VALUES
(1, 'Lightyear 2022', 'Angus Maclane, Matthew Aldrich, Jason Headley', 'Chris Evans, Keke Palmer, Peter Sohn, Taika Waititi', 'Adventure, Animation, Action, Science Fiction, Family', 4803205, '0-10-20-2022-222131f2d0ac7219f756a6079348b48e-7e933184f96d90552ea269adda046270.mp4', '2-10-20-2022-222131f2d0ac7219f756a6079348b48e-c72581ae5f96ff157119332e51418466.jpg', '1-10-20-2022-222131f2d0ac7219f756a6079348b48e-29757930a04ea4de40729de64150a718.jpg', 0, 0, 0, '2022-06-15', '2022-10-20 20:12:12'),
(2, 'Raya and the Last Dragon', 'Carlos Lopez Estrada, Don Hall', 'Family, Animation, Fantasy, Action, Adventure', 'Awkwafina, Kelly Marie Tran, Benedict Wong, Lucille Soong, Gemma Chan', 8142135, '0-10-20-2022-222131f2d0ac7219f756a6079348b48e-ba43989ae220047829bff07e131415f5.mp4', '2-10-20-2022-222131f2d0ac7219f756a6079348b48e-e4ed84c4c51c3d8550f54d636fffee10.jpg', '1-10-20-2022-222131f2d0ac7219f756a6079348b48e-d819e5da697405dab5299ea2622e72b1.jpg', 0, 0, 0, '2021-03-03', '2022-10-20 20:17:14'),
(3, 'Spider-Man: Homecoming 2017', 'Jonathan Goldstein, John Francis Daley & Jon Watts', 'Action, Adventure, Science Fiction, Drama', 'Jacob Batalon, Abraham Attah, Hemky Madera, Bokeem Woodbine, Zendaya', 15381056, '0-10-20-2022-222131f2d0ac7219f756a6079348b48e-8ed5fd37d7c6334efca8b756b87a910b.mp4', '2-10-20-2022-222131f2d0ac7219f756a6079348b48e-25052efc9d1083625cd1d71bc60d1ff7.jpg', '1-10-20-2022-222131f2d0ac7219f756a6079348b48e-77f94f7d40c9cc98610041ad2e8e8337.jpg', 0, 0, 0, '2017-07-07', '2022-10-20 20:25:39'),
(4, 'The Nun', 'Gary Dauberman', 'Horror, Mystery, Thriller', 'Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch', 3221489, '0-10-20-2022-222131f2d0ac7219f756a6079348b48e-aa1fa16632de7f5b11415496a50cccfa.mp4', '2-10-20-2022-222131f2d0ac7219f756a6079348b48e-9bbb8e4c5c81b9d218b52ddcdc86c2e5.jpg', '1-10-20-2022-222131f2d0ac7219f756a6079348b48e-1e942e08ccdc781dcf999ba538824ce1.png', 0, 0, 0, '2018-09-09', '2022-10-20 20:28:30'),
(5, 'Fifty Shades of Grey', 'E. L. James', 'Drama, Romance, Thriller', 'Jamie Dornan, Victor Rasuk, Eloise Mumford, Raj Lal, Callum Keith Rennie', 12857350, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-14cb343ec554f6a66205ca7df009c806.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-00053705859df4fb1d294ca906ba5884.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-501d5b34b4be439b6acbdc054828faa2.jpg', 0, 0, 0, '2015-02-11', '2022-10-21 04:08:36'),
(6, 'After We Fell', 'Anna Todd', 'Romance, Drama', 'Josephine Langford, Hero Fiennes Tiffin, Chance Perdomo, Carter Jenkins, Kiana Madeira', 16789437, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-3043db8421b39a9aeb815bab40a7b91e.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-19708446f3f176a092975f1f77e77df0.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-9dd6714a10f9371a294766683aff7b65.jpg', 0, 0, 0, '2021-09-09', '2022-10-21 04:10:55'),
(7, 'Dog', 'Channing Tatum, Reid Carolin', 'Drama, Comedy', 'Amanda Booth, Ethan Suplee, Aqueela Zoll, Bill Burr, Cayden Boyd', 8218723, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-4db10496f4714ea1f3345197ade1600e.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-37a148f236f844f06410f9fb79e382ec.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-a42a6bd2a997bb6904926addea242075.jpg', 0, 0, 0, '2022-02-17', '2022-10-21 04:12:15'),
(8, 'The Secret Life of Pets', 'Chris Renaud', 'Adventure, Comedy, Animation, Family', 'Louis C.K., Eric Stonestreet, Kevin Hart, Jenny Slate, Lake Bell', 19746841, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-9a195901c70a757050b9bcfefe914785.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-9320365eab0f83f64a82568e4b5cbfb2.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-9ea6740b8bc899a33408609a23e21c36.jpg', 0, 0, 0, '2016-06-18', '2022-10-21 04:13:48'),
(9, 'The Secret Life of Pets 2', 'Chris Renaud', 'Comedy, Adventure, Animation, Family', 'Bobby Moynihan, Ellie Kemper, Albert Brooks, Kevin Hart, Hannibal Buress', 17385883, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-7fba4fcedd3818f43b444e920ff9a025.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-7e1963bc26bd25f273ba8a885120289d.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-f311a36a7c9006286e1930db16bc02dd.jpg', 0, 0, 0, '2019-05-24', '2022-10-21 04:15:13'),
(10, 'Pets United', 'Reinhard Klooss', 'Animation, Adventure, Comedy, Family', 'Natalie Dormer, Jeff Burrell, Harvey Friedman, Andres Williams, Naomi McDonald', 30961544, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-4b29257d7ad2b1356e7bf15a511cb9eb.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-765468c82501de63e192848cace140e0.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-9b3f146a10eccc74dd04e7b7ec01cf81.jpg', 0, 0, 0, '2020-09-11', '2022-10-21 04:16:35'),
(11, 'Wish Dragon', 'Chris Appelhans', 'Family, Comedy, Animation, Fantasy', 'Bobby Lee, John Cho, Will Yun Lee, Jimmy Wong, Ian Chen', 14550698, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-afd2e117845333801d86ebe3e0ca0b7c.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-a6e0f4986f3ba8bf392a8670b56b0afa.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-7c46133050c0063d207121483eb78f86.jpg', 0, 0, 0, '2021-01-15', '2022-10-21 04:17:47'),
(12, 'Luca', 'Enrico Casarosa', 'Family, Animation, Comedy, Fantasy', 'Jack Dylan Grazer, Maya Rudolph, Sandy Martin, Emma Berman, Jacob Tremblay', 3742405, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-21877942691187270708529b41a04be8.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-bef189fcc4cf9d679f49b3fe7e7e69a6.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-3e0417515f258a380cde8860b4f9d313.png', 0, 0, 0, '2021-06-17', '2022-10-21 04:18:50'),
(13, 'Deadstream', 'Joseph Winter, Vanessa Winter', 'Horror, Comedy', 'Joseph Winter, Perla Lacayo, Pat Barnett Carr, Marty Collins, Melanie Stone', 9031315, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-05f463b545a1c91481e7cbda1f06a354.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-41d6fbc70e10870326afc4978a813ea9.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-2304cc2d616bb5ca9217e1ee0a0d0161.jpg', 0, 0, 0, '2022-10-20', '2022-10-21 04:20:39'),
(14, 'Enola Holmes', 'Nancy Springer', 'Mystery, Adventure, Crime, Drama', 'Fiona Shaw, Burn Gorman, Frances de la Tour, Jay Simpson, Owen Atlas', 6737186, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-0a28c58ed4bc2f8296ed8fd58d9856c2.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-a7a51b4a3ce2c98cf25e134c19278131.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-b145813e4838d226e52729d817af1241.jpg', 0, 0, 0, '2020-09-23', '2022-10-21 04:23:35'),
(15, 'Under Wraps 2', 'Josh A. Cagan', 'Fantasy, Family, TV Movie', 'Melanie Brook, Sophia Hammons, Rryla McIntosh, Phil Wright, Christian J. Simon', 4375543, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-308449005e380eeb44fdb1c415d7b8a7.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-96ed0db232583a09e77490ef62b9a1c7.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-f48de9e8f68b64649b080b40edf8f1df.jpg', 0, 0, 0, '2022-09-25', '2022-10-21 04:24:58'),
(16, 'Minions: The Rise of Gru', 'Brian Lynch', 'Family, Adventure, Animation, Comedy, Action', 'Russell Brand, Alan Arkin, Taraji P. Henson, Steve Carell, Pierre Coffin', 9231572, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-f64bcb6a8b2bd72b5c0f602fc37fbab4.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-b8f520d459634c029517938a60c030b0.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-e9b247be5cedaacd7b620edc7a63654a.jpg', 0, 0, 0, '2022-06-16', '2022-10-21 04:26:37'),
(17, 'Jurassic World Dominion', 'Derek Connolly', 'Adventure, Action, Science Fiction, Thriller', 'Chris Pratt, Bryce Dallas Howard, Isabella Sermon, Laura Dern, Sam Neill', 13653163, '0-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-5dc8f9e93e7d062eb40d9b6c961d0b7c.mp4', '2-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-0d2fa30629c479fa7fc0f85663f220fc.jpg', '1-10-21-2022-b120cabce63d2aaa8d23b039c006fe02-2ec66ac7983c50e0c0ebc4fe4386b427.jpg', 0, 0, 0, '2022-06-01', '2022-10-21 04:28:11'),
(21, 'Puss in Boots: The Last Wish', 'Joel Crawford', 'Adventure, Action', 'Antonio Banderas, Olivia Colman', 10443680, '0-01-15-2023-3c0dded3fa752a976bcf4d15fe231cf8-6f3b4948d317d95883b4250d6f6411f3.mp4', '2-01-15-2023-3c0dded3fa752a976bcf4d15fe231cf8-f3b727851aa69ecb8c7cb577c02ffe24.jpg', '1-01-15-2023-3c0dded3fa752a976bcf4d15fe231cf8-df097bcec0ed8f4d6ebd5dc752586842.jpg', 0, 0, 0, '2022-12-21', '2023-01-15 11:28:52');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `email`, `firstName`, `lastName`, `password`, `role`) VALUES
('5ad198d4-8cae-45d2-ba5a-e6882f1172bb', 'user1@gmail.com', 'John', 'Ramos', '1bbd886460827015e5d605ed44252251', 'user'),
('627425da-702f-4ead-86d0-ef4d1644cbbc', 'admin', 'Admin', 'Admin', '21232f297a57a5a743894a0e4a801fc3', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `history`
--
ALTER TABLE `history`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `history`
--
ALTER TABLE `history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `movie`
--
ALTER TABLE `movie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
