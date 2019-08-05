import numpy as np

step_size = 0.005

def get_diff(w1: float, v1: int, rho: float, w2: float):
	return w1 * (rho-1) * (v1+0.5) - (w2 * (rho-1) * 0.5)


def findw1(target: float, w2: float, vrange: str, rho: float, w1range: str) -> str:
	vrange = vrange.split(',')
	w1range = w1range.split(',')

	result = ""

	for v in range(int(vrange[0]), int(vrange[1]) + 1):
		current_diff = float("inf")
		w1 = None

		for w in np.arange(float(w1range[0]), float(w1range[1]) + step_size, step_size):
			new_diff = abs(float(target) - get_diff(float(w), int(v), float(rho), float(w2)))
		
			if (new_diff < current_diff):
				w1 = w
				current_diff = new_diff

		result += f"v={v}:\t\u03C9={w1}\n"

	return result