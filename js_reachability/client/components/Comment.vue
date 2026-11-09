<template>
  <div class="comment" v-html="safeHtml"></div>
</template>

<script>
import DOMPurify from 'dompurify';

export default {
  props: ['html'],
  computed: {
    safeHtml() {
      return DOMPurify.sanitize(this.html);
    },
  },
};
</script>
