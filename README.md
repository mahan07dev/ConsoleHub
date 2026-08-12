# Mahan07dev | Console Hub (v2.3.1) ⚡

A modular C# command-line workspace application featuring security routines, web/developer utilities, system metrics, and an interactive personal portfolio—all wrapped in a keyboard-navigable CLI.

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