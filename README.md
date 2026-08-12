# Mahan07dev | Console Hub (v2.3.1) ⚡

A modular C# command-line workspace application featuring security routines, web/developer utilities, system metrics, and an interactive personal portfolio—all wrapped in a keyboard-navigable CLI.

---

## ✨ Features & Structure

* **🔐 Security & Dev Tools:**
  * Cryptographically secure password generator.
  * Password strength evaluator[cite: 1].
  * 32-character API key generator[cite: 1].
  * SHA-256 hash generator[cite: 1].
  * Base64 encoder/decoder[cite: 1].

* **🌐 Web / Dev Utilities:**
  * UUID/GUID generator[cite: 1].
  * Unix timestamp converter[cite: 1].
  * URL codec (Escape Data String)[cite: 1].
  * HTTP status lookup helper[cite: 1].

* **🛠️ System Info:**
  * Live monitoring of OS version, machine name, CPU core count, system architecture, and runtime uptime[cite: 1].

* **ℹ️ Interactive Portfolio & Links:**
  * Displays developer profile, core technology stack, and personal links (GitHub, Telegram, MahanVerse, LogoShop, Portfolio)[cite: 1].

* **⚙️ Logging & Configuration:**
  * Persisted runtime configurations saved to `config.json` (theme settings, default password length, logging flags)[cite: 1].
  * Automated file logging for session tracking and error reporting (`logs/app.log`)[cite: 1].

---

## 🛠️ Tech Stack & Architecture

* **Language:** C#[cite: 1]
* **Target Runtime:** .NET Console Application[cite: 1]
* **Navigation:** Custom arrow-key/keyboard-driven interactive menu engine (`ConsoleKey.UpArrow`, `ConsoleKey.DownArrow`, `ConsoleKey.Enter`, `ConsoleKey.Escape`)[cite: 1]
* **Security:** `System.Security.Cryptography` (`RandomNumberGenerator`, `SHA256`)[cite: 1]

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