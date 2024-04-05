Feature: BookshopSystem

As a customer
  I want to order books from the bookshop
  So that I can receive them promptly

Scenario: Ordering an available book
    Given the bookshop contains the following books:
      | Id | Title   | Author       | Price | Isbn          | Publisher |
      | 1  | Bastion | Stephen King | 39.99 | 9788383610672 | Albatros  |
    When I order "1"
    Then I should receive an order confirmation

Scenario: Ordering an unavailable book
    Given the bookshop contains no books
    When I order "Nonexistent Book"
    Then I should receive an error message