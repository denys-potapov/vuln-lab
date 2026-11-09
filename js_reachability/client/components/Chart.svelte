<script>
  import axios from 'axios';

  export let url;
  let points = [];

  axios.get(url).then((response) => { points = response.data; });
</script>

<ul>
  {#each points as point}<li>{point.x}: {point.y}</li>{/each}
</ul>
