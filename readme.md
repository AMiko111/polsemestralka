# Objednávací systém v menze (UTB Minute)

Semestrální projekt do předmětu **Aplikační frameworky** (Půlsemestrální odevzdání).

## Členové týmu a poměr práce
| Jméno a příjmení | Role v týmu | Poměr práce |
| :--- | :--- | :---: |
| Adam Miko - vedoucí | Minute.Db & Contracts | 1 |
| Teodor Kapitanov | Testování | 1 |
| Liubov Doroshenko | WebAPI & DbManager | 1 |
---

## Spuštění projektu

1. **Požadavky**: .NET 10 SDK, Docker Desktop.
2. **Postup**:
    * Spusťte Docker Desktop.
    * Otevřete solution `UTB.Minute.sln` ve Visual Studiu 2026.
    * Nastavte projekt **`UTB.Minute.AppHost`** jako **Start-up projekt**.
    * Spusťte projekt.
    * V prohlížeči se otevře .NET Aspire Dashboard, kde uvidíte stav všech služeb.
---

## Struktura řešení

* **`UTB.Minute.AppHost`**: Aspire orchestrace, správa kontejneru s PostgreSQL a propojení služeb.
* **`UTB.Minute.Db`**: Datové entity (`Meal`, `Order`, `MenuItem`) a konfigurace `DbContext`.
* **`UTB.Minute.DbManager`**: Nástroj pro inicializaci databáze.
* **`UTB.Minute.Contracts`**: Sdílené DTO třídy pro zajištění typové bezpečnosti při komunikaci přes API.
* **`UTB.Minute.WebApi`**: Hlavní business logika, implementace endpointů pro jídla, menu a objednávky.
* **`UTB.Minute.WebApi.Tests`**: Integrační testy ověřující správnou funkčnost API endpointů.

---


## Seznam API endpointů

### MealEndpoints
* GET /meals - Seznam všech jídel.
* GET /meals/{id} - Detail konkrétního jídla.
* POST /meals - Vytvoření nového jídla.
* PUT /meals/{id} - Úprava jídla.

### MenuItemEndpoints
* GET /menu-items - Seznam všech položek menu.
* GET /menu-items/today - Aktuální denní nabídka.
* GET /menu-items/{id} - Detail položky menu.
* POST /menu-items - Přidání položky do menu.
* PUT /menu-items/{id} - Úprava položky menu.
* DELETE /menu-items/{id} - Odstranění položky z menu.

### OrderEndpoints
* GET /orders - Seznam všech objednávek.
* GET /orders/{id} - Detail objednávky.
* POST /orders - Vytvoření nové objednávky studentem.
* PATCH /orders/{id}/status - Změna stavu objednávky.

### DbManager
* POST /reset - Kompletní reset databáze a seed dat.
