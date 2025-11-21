(() => {
    let scene, camera, renderer, controls;
    let orbitObjects = [];
    let planet;

    function init() {
        const canvas = document.getElementById("hubCanvas");
        const width = canvas.clientWidth || window.innerWidth;
        const height = canvas.clientHeight || window.innerHeight;

        // Scene setup
        scene = new THREE.Scene();
        scene.background = new THREE.Color(0x000000);

        // Camera
        camera = new THREE.PerspectiveCamera(60, width / height, 0.1, 1000);
        camera.position.set(0, 0, 30);

        // Renderer
        renderer = new THREE.WebGLRenderer({ canvas, antialias: true });
        renderer.setSize(width, height, false);
        renderer.setPixelRatio(window.devicePixelRatio);

        // Lights
        const ambient = new THREE.AmbientLight(0xffffff, 0.3);
        const point = new THREE.PointLight(0xffffff, 1.5);
        point.position.set(10, 10, 25);
        scene.add(ambient, point);

        // Core (Tarazism planet)
        const coreGeo = new THREE.SphereGeometry(3, 32, 32);
        const coreMat = new THREE.MeshStandardMaterial({
            color: 0xffffff,
            emissive: 0x333333,
            metalness: 0.4,
            roughness: 0.3
        });
        planet = new THREE.Mesh(coreGeo, coreMat);
        scene.add(planet);

        // Orbit controls
        controls = new THREE.OrbitControls(camera, renderer.domElement);
        controls.enableZoom = false;
        controls.autoRotate = true;
        controls.autoRotateSpeed = 0.5;

        // Orbiting labels
        const categories = ["Games", "Anime", "Movies", "Books", "Music", "Art", "Photos", "Series"];
        const radius = 12;

        categories.forEach((text, i) => {
            const canvasText = document.createElement("canvas");
            const ctx = canvasText.getContext("2d");
            canvasText.width = 256;
            canvasText.height = 64;
            ctx.fillStyle = "white";
            ctx.font = "bold 28px Arial";
            ctx.textAlign = "center";
            ctx.fillText(text, 128, 40);

            const texture = new THREE.CanvasTexture(canvasText);
            const material = new THREE.SpriteMaterial({ map: texture });
            const sprite = new THREE.Sprite(material);

            const angle = (i / categories.length) * Math.PI * 2;
            sprite.position.set(Math.cos(angle) * radius, Math.sin(angle) * radius, 0);
            scene.add(sprite);
            orbitObjects.push({ sprite, angle });
        });

        window.addEventListener("resize", onWindowResize);
        animate();
    }

    function onWindowResize() {
        const canvas = document.getElementById("hubCanvas");
        const width = canvas.clientWidth || window.innerWidth;
        const height = canvas.clientHeight || window.innerHeight;
        camera.aspect = width / height;
        camera.updateProjectionMatrix();
        renderer.setSize(width, height, false);
    }

    function animate() {
        requestAnimationFrame(animate);

        orbitObjects.forEach((obj) => {
            obj.angle += 0.002;
            const r = 12;
            obj.sprite.position.set(Math.cos(obj.angle) * r, Math.sin(obj.angle) * r, 0);
        });

        controls.update();
        renderer.render(scene, camera);
    }

    init();
})();
