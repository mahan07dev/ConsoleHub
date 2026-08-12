<div align="center">

<img src="https://raw.githubusercontent.com/Mahan07dev/ConsoleHub/main/icon.png" width="130" alt="Logo">
<br>

# Mahan07dev | Console Hub ⚡

A modular C# command-line workspace application featuring security routines, web/developer utilities, system metrics, and an interactive personal portfolio—all wrapped in a keyboard-navigable CLI.

<p>
<a href="https://github.com/Mahan07dev/ConsoleHub/releases"><img src="https://img.shields.io/badge/🚀%20Install%20right%20now!-7c3aed?style=for-the-badge" /></a>
<br><br>
<a href="https://github.com/Mahan07dev/ConsoleHub/releases">
  <img src="https://img.shields.io/github/v/release/Mahan07dev/ConsoleHub?style=for-the-badge" alt="Latest Version">
</a>
<a href="https://github.com/Mahan07dev/ConsoleHub/releases">
  <img src="https://img.shields.io/github/release-date/Mahan07dev/ConsoleHub?style=for-the-badge" alt="Latest Release Date">
</a>
<a href="https://github.com/Mahan07dev/ConsoleHub"><img src="https://img.shields.io/github/stars/Mahan07dev/ConsoleHub?style=for-the-badge" /></a>
<a href="https://github.com/Mahan07dev/ConsoleHub/blob/main/LICENSE"><img src="https://img.shields.io/github/license/Mahan07dev/ConsoleHub?style=for-the-badge" /></a>
</p>
</div>

---

## ✨ Features & Structure

* **🔐 Security & Dev Tools:**
  * Cryptographically secure password generator.
  * Password strength evaluator.
  * 32-character API key generator.
  * SHA-256 hash generator.
  * Base64 encoder/decoder.

* **🌐 Web / Dev Utilities:**
  * UUID/GUID generator.
  * Unix timestamp converter.
  * URL codec (Escape Data String).
  * HTTP status lookup helper.

* **🛠️ System Info:**
  * Live monitoring of OS version, machine name, CPU core count, system architecture, and runtime uptime.

* **ℹ️ Interactive Portfolio & Links:**
  * Displays developer profile, core technology stack, and personal links (GitHub, Telegram, MahanVerse, LogoShop, Portfolio).

* **⚙️ Logging & Configuration:**
  * Persisted runtime configurations saved to `config.json` (theme settings, default password length, logging flags).
  * Automated file logging for session tracking and error reporting (`logs/app.log`).

---

## 🛠️ Tech Stack & Architecture

* **Language:** C#
* **Target Runtime:** .NET Console Application
* **Navigation:** Custom arrow-key/keyboard-driven interactive menu engine (`ConsoleKey.UpArrow`, `ConsoleKey.DownArrow`, `ConsoleKey.Enter`, `ConsoleKey.Escape`)
* **Security:** `System.Security.Cryptography` (`RandomNumberGenerator`, `SHA256`)

---

## 🚀 Quick Start

### 1. Prerequisites
* [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

### 2. Run from Source

```bash
# Clone the repository
git clone [https://github.com/mahan07dev/ConsoleHub.git](https://github.com/mahan07dev/ConsoleHub.git)

# Navigate to the project directory
cd ConsoleHub

# Build and run
dotnet run
```

## Standalone Executable / Release
Check the Releases section to download pre-compiled binaries or installer packages.

---

# 📂 Configuration & Logs
When launched, the application automatically initializes default environment settings if they do not exist:

- **Config File** (`config.json`): Manages settings like default theme, password length, and logging behavior.

- **Logs Directory** (`logs/app.log`): Records operational events and runtime crash logs.

```JSON
{
  "Theme": "Green",
  "DefaultPasswordLength": 16,
  "LoggingEnabled": true
}
```

---

# 📄 License
Distributed under the MIT License. See [**LICENSE**](./LICENCE) for more information.

---