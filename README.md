<div id="top"></div>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">


<h3 align="center">AC/CA Audio</h3>

  <p align="center">
    C# GUI project for telecommunication class in TUL.
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About the project</a></li>
    <li><a href="#built-with">Built With</a></li>
    <li><a href="#some-screens-from-project">Some screens from project</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
One of the tasks made for telecomunnication class in TUL. Other is [X-MODEM protocol](https://github.com/pStrachota/X-MODEM-TELEKOM).
This project is not just simple audio recorder/player - our main challenge was to create this kind of utility, but as low level
as possible. In order to achieve that, ***mciSendString*** command was used.

From [documentation](https://docs.microsoft.com/en-us/previous-versions/dd757161(v=vs.85)) - *The mciSendString function sends a command string to an MCI device. The device that the command is sent to is specified in the command string*. So in our case MCI devices are microphone and speakers.

Due to that this code is quite small, we didn't use MVVM for application construction.


<p align="right">(<a href="#top">back to top</a>)</p>

## Some screens from project
- ### Starting screen
![screen](https://i.imgur.com/D4xwLPy.png)
<br />
<br />
- ### Choosing sample rate and bit depth
![screen2](https://i.imgur.com/CBCv5HT.png)
<br />
<br />
- ### Choosing wav file to save
![screen3](https://i.imgur.com/gaS0Qsc.png)
<br />
<br />
- ### recording audio
![screen4](https://i.imgur.com/4OC8DUL.png)
<br />
<br />
- ### end of recording
![screen5](https://i.imgur.com/G8DjS8t.png)
 

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [WPF](https://docs.microsoft.com/pl-pl/dotnet/desktop/wpf/?view=netdesktop-6.0)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/pStrachota/AC-CA-AUDIO.svg?style=for-the-badge
[contributors-url]: https://github.com/pStrachota/AC-CA-AUDIO/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/pStrachota/AC-CA-AUDIO.svg?style=for-the-badge
[forks-url]: https://github.com/pStrachota/AC-CA-AUDIO/network/members
[stars-shield]: https://img.shields.io/github/stars/pStrachota/AC-CA-AUDIO.svg?style=for-the-badge
[stars-url]: https://github.com/pStrachota/AC-CA-AUDIO/stargazers
[issues-shield]: https://img.shields.io/github/issues/pStrachota/AC-CA-AUDIO.svg?style=for-the-badge
[issues-url]: https://github.com/pStrachota/AC-CA-AUDIO/issues
[license-shield]: https://img.shields.io/github/license/pStrachota/AC-CA-AUDIO.svg?style=for-the-badge
[license-url]: https://github.com/pStrachota/AC-CA-AUDIO/blob/master/LICENSE.txt


