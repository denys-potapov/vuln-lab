// Packages loaded lazily with dynamic import()
async function renderReport(markdown) {
  const { marked } = await import(`marked`);
  return marked.parse(markdown);
}

async function fetchFeed(url) {
  const { default: fetch } = await import('node-fetch');
  const response = await fetch(url);
  return response.json();
}

// Only a message: the xml parser is not used here
const XML_HINT = 'feeds in xml need xml2js, not supported yet';

module.exports = { renderReport, fetchFeed, XML_HINT };
