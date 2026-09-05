# Modern Calculator

A modern, feature-rich calculator application built with C# and Windows Forms, carefully designed to replicate the look, feel, and functionality of the **Windows 11 Calculator**. It provides a user-friendly clean interface with advanced mathematical operations, calculation history, and full keyboard support.

## Features

- **Basic Operations**: Addition, subtraction, multiplication, and division.
- **Advanced Operations**: 
  - Reciprocal (1/x).
  - Square root (²√x).
  - Power of 2 (x²).
  - Percentage calculations.
  - Sign toggle (±).
- **Calculation History**: View and track all previous calculations.
- **Keyboard Support**: Full keyboard input for numbers and operations.
- **Number Formatting**: Automatic number formatting with thousand separators.
- **Error Handling**: Clear error messages for invalid operations (e.g., division by zero).
- **Borderless UI**: Modern, custom-designed user interface.

## Technical Details

- **Language**: C# 7.3
- **.NET Framework**: .NET Framework 4.7.2
- **UI Framework**: Windows Forms
- **Custom Controls**: Rounded button controls for modern appearance.

## Getting Started

### Prerequisites

- .NET Framework 4.7.2 or higher.
- Windows operating system.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yahiaalsebaie/Modern-Calculator.git
   ```

2. Open the project in Visual Studio 2022.

3. Build and run the application.

## Usage

### Mouse Input
- Click number buttons to enter values.
- Click operation buttons to perform calculations.
- Click "=" to compute the result.
- Use "C" to clear all, "CE" to clear entry, and backspace to delete the last digit.

### Keyboard Input
- **0-9**: Number input
- **+, -, *, /**: Basic operations
- **Enter**: Calculate result
- **Backspace**: Delete last digit
- **Escape**: Clear all (C)
- **Delete**: Clear entry (CE)
- **. (Period/Decimal)**: Decimal point
- **% (Shift+5)**: Percentage
- **Shift+8**: Multiply

## Code Structure

- **Form1.cs**: Main calculator logic and event handlers.
- **ctrlRoundedButton**: Custom rounded button control.
- **FormattedNumber()**: Handles number formatting with thousand separators.

## Key Operations

| Operation | Symbol | Keyboard |
|-----------|--------|----------|
| Add | + | + |
| Subtract | - | - |
| Multiply | × | * or Shift+8 |
| Divide | ÷ | / |
| Reciprocal | ⅟x | N/A |
| Square Root | ²√x | N/A |
| Power of 2 | x² | N/A |
| Percentage | % | Shift+5 |
| Sign Toggle | ± | N/A |

## Features Details

### History Panel
- Automatically tracks all calculations.
- Displays calculations in reverse chronological order.
- Toggle history panel with the History button.
- Clear history with the "Clear History" button.

### Error Handling
- Division by zero protection.
- Invalid square root input (negative numbers) protection.
- User-friendly error messages.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is open source and available on [GitHub](https://github.com/yahiaalsebaie/Modern-Calculator).

## Author

[Yahia Alsebaie](https://github.com/yahiaalsebaie)

### Improvements Made:
1. **Consistency in Punctuation**: Added periods at the end of bullet points for consistency.
2. **Clarity and Readability**: Improved the flow of sentences and added minor clarifications where necessary.
3. **Formatting**: Ensured consistent formatting throughout the document for better readability.
4. **Structure**: Maintained the original structure while enhancing the content for clarity and completeness.