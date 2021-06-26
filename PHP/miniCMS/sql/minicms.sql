-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 26, 2021 at 11:17 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `minicms`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `Codigo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `userName`, `Codigo`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3');

-- --------------------------------------------------------

--
-- Table structure for table `conteudos`
--

CREATE TABLE `conteudos` (
  `id` int(11) NOT NULL,
  `pagina` varchar(50) NOT NULL,
  `titulo` varchar(50) NOT NULL,
  `texto` longtext NOT NULL,
  `autor` varchar(50) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `conteudos`
--

INSERT INTO `conteudos` (`id`, `pagina`, `titulo`, `texto`, `autor`, `data`) VALUES
(1, 'home', 'Home', '<h2>Introduction</h2><p>In this series, I will be listing out five things that I feel every flutter developer should know. With more experience and observation, I will create more parts. If you are an experienced flutter developer, you may know these already, but Iâ€™ll still put them out there. Who knows! Someone else might find them Interesting.</p><h3>No 1: Container â€” The Swiss Army Knife.</h3><p>A <strong>Container</strong> is a very powerful widget, but sometimes we tend to miss out on some of its benefits when working with it. I canâ€™t count how many times Iâ€™ve missed out on taking advantage of this tool and ended up adding some unnecessary widgets to the widget tree. I call it â€œ<strong>the widget of widgets</strong>â€ because a single container has the properties of some other Flutter widgets such as <strong>Align</strong>,<strong> Padding</strong>,<strong> ConstrainedBox</strong>, etc. when properly used. You can check out this article, <a href=\"https://medium.com/flutter-community/flutters-container-this-ain-t-your-daddy-s-div-100817339610\">Flutterâ€™s Container: This ainâ€™t your Daddyâ€™s div</a> for more amazing container properties.</p><p>The sample code below shows examples of code snippets producing similar results with the second code taking advantage of the benefits of containers.</p>', 'miniCMS', '2021-06-26'),
(2, 'servicos', 'Servicos', '<h3>No 2: Donâ€™t animate Opacity widget</h3><blockquote><p><i>Animating an </i><a href=\"https://api.flutter.dev/flutter/widgets/Opacity-class.html\"><i>Opacity</i></a><i> widget directly causes the widget (and possibly its subtree) to rebuild each frame, which is not very efficient. Consider using an </i><a href=\"https://api.flutter.dev/flutter/widgets/AnimatedOpacity-class.html\"><i>AnimatedOpacity</i></a><i> instead.</i></p></blockquote><p>According to the opacity <a href=\"https://api.flutter.dev/flutter/widgets/Opacity-class.html\">documentation,</a> animating the opacity widget should be avoided. Using the AnimatedOpacity or the <a href=\"https://api.flutter.dev/flutter/widgets/FadeTransition-class.html\">FadeTransition </a>widget should be preferred for implementing a similar behavior.</p><h3>No 3: Consider making use of cascade notation (..)</h3><p><a href=\"https://dart.dev/guides/language/language-tour#cascade-notation-\">Cascade notation</a> allows multiple methods to be called on the same object. If you are coming from other OOP languages, It might feel strange to see this syntax because achieving such in other languages requires you to return â€œthisâ€ from the methods.</p><blockquote><p><i>This often saves you the step of creating a temporary variable and allows you to write more fluid code.</i></p></blockquote><p>A typical example of when cascade notation can come in handy is when creating a custom clipper.</p><h3>No 4: Fitted box is here for you</h3><p>Have you ever been in a Situation where you want a widget to fit in another widget or the screen irrespective of the size? If you have had such a need, fitted box is the right widget for you.</p><p>In the example below, I try to fit the number boxes in a row into different containers of different sizes. This leads to an overflow in the second and third case since the contents are number box row is bigger than the containers.</p><h3><br>No 5: Discard the new keyword</h3><p>If you are new to Flutter, You might come across some old codes where object instances are created with the <strong>new </strong>keyword. Its usage became optional with the introduction of Dart 2 (check more on it <a href=\"https://medium.com/dartlang/announcing-dart-2-80ba01f43b6#da82\">here</a> ). Writing your code without the new keyword makes it much neater to work with.</p><h3>Conclusion</h3><p>Flutter is very interesting to work with and the more you work with it is the more you get to learn new things about it. I will be writing some more articles after this as a way of contributing to the flutter community.</p>', 'miniCMS', '2021-06-26'),
(5, 'migration', 'Migration', '<h2><strong>Danâ€™s Quick Flutter 2 Migration Guide</strong></h2><p>Some of you built the app using an older version of flutter, the current version I have is 1.22.6 so latest from version 1 of flutter.</p><p>You might already know this but, create a new branch before doing this work :)</p><p>&nbsp;</p><h2>There are plugins that still donâ€™t have null-safety support, what can I do?</h2><p>Obviously I now have a tone of plugins that do not have null-safety support, so I tried to find GitHub versions of those plugins with null-safety until I wait for an official version to be released for those plugins.</p><p>For some plugins I decided to keep them in the root folder of the project as its easier for me to later on remember which ones I need to change.</p><p>For other plugins I had to manually add the null-safety support, hereâ€™s how you can do it. <i>(this applies to plugins and projects)</i></p>', 'daniel', '0000-00-00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `conteudos`
--
ALTER TABLE `conteudos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `conteudos`
--
ALTER TABLE `conteudos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
