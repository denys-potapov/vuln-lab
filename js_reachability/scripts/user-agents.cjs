// Counts browsers in an access log (CommonJS script): node scripts/user-agents.cjs < access.log
const UAParser = require('ua-parser-js');

const counts = {};
require('node:fs').readFileSync(0, 'utf8').split('\n').filter(Boolean).forEach((line) => {
  const { browser } = new UAParser(line).getResult();
  counts[browser.name] = (counts[browser.name] || 0) + 1;
});
console.log(counts);
