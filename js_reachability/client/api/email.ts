export function isValidEmail(value: string): boolean {
  return /^[^@\s]+@[^@\s]+$/.test(value);
}
